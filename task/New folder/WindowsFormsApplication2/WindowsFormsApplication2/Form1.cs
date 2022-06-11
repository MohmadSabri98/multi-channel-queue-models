using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiChannelQueueModels;




namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        TimeDistribution [] dist_time;
        Server[] server;
        SimualtionCase[] smulation;
        Enums enm;

        public Form1()
        {


            InitializeComponent();
            pnlPatients.Visible = false;
            panel1.Visible = false;
                part.Visible=false;
                chart1.Visible = false;
            smulation = new SimualtionCase[100];
            enm=new Enums();

        }

        int num_servers = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.Columns.Clear();
            pnlPatients.Visible = !pnlPatients.Visible;
            if (checkBox1.Checked)
            {
                dataGrid1.Columns.Add("time", "time");
                dataGrid1.Columns.Add("probablity", "probablity");
                dataGrid1.Columns.Add("cum_probablity", "cum_probablity");
                dataGrid1.Columns.Add("max", "max");
                dataGrid1.Columns.Add("nin", "min");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
            
            DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
            row.Cells[0].Value = t.Text;
            row.Cells[1].Value = p.Text;
            row.Cells[2].Value = 0;
            row.Cells[3].Value = 0;
            row.Cells[4].Value = 0;
            dataGrid1.Rows.Add(row);
            double r = Convert.ToDouble(row.Cells[1].Value)*100;
           /* if(dataGrid1.Rows[dataGrid1.Rows.Count-2].Cells[0].Value !=null)
            l.Text = dataGrid1.Rows[dataGrid1.Rows.Count-2].Cells[0].Value.ToString() ;
            */
            l.Text = dataGrid1.Rows.Count.ToString();
        }
        public int time_len = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            double pro = 0.0;
            time_len = dataGrid1.Rows.Count - 1;
            dist_time = new TimeDistribution[dataGrid1.Rows.Count - 1];
            MessageBox.Show(dist_time.Length.ToString());
            for (int i = 0; i < dataGrid1.Rows.Count - 1; i++)
            {
                dist_time[i] = new TimeDistribution();

                if (dataGrid1.Rows[i].Cells[0].Value != null)
                {

                    dist_time[i].Time = Convert.ToInt32(dataGrid1.Rows[i].Cells[0].Value);


                }

                if (dataGrid1.Rows[i].Cells[1].Value != null)
                {
                    dist_time[i].Probability = Convert.ToDouble(dataGrid1.Rows[i].Cells[1].Value);
                    pro = Convert.ToDouble(dataGrid1.Rows[i].Cells[1].Value) * 100;
                    sum += dist_time[i].Probability;
                    dist_time[i].CummProbability = sum;
                    if (i == 0)
                    {
                        dist_time[i].MinRange = 1;
                        dist_time[i].MaxRange = pro;

                    }
                    else
                    {
                        dist_time[i].MinRange = dist_time[i - 1].MaxRange + 1;
                        if (dist_time[i].MinRange + pro >= 100)
                        {
                            dist_time[i].MaxRange = 99;

                        }
                        else
                        {
                            dist_time[i].MaxRange = dist_time[i].MinRange + pro - 1;
                        }
                    }



                }
               // MessageBox.Show(dist_time[i].Time.ToString() + " " + dist_time[i].Probability.ToString() + " " + dist_time[i].CummProbability.ToString() + " " + dist_time[i].MinRange.ToString() + "   " + dist_time[i].MaxRange.ToString());

            }

        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            double ss = (double)5 / (double)2;
            tgrba.Text = ss.ToString();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


        }




        private void show_time1(object sender, EventArgs e)
        {
            //MessageBox.Show(dist_time[0].Time.ToString() + " " + dist_time[0].Probability.ToString() + " " + dist_time[0].CummProbability.ToString() + " " + dist_time[0].MinRange.ToString() + "   " + dist_time[0].MaxRange.ToString());
            dataGrid1.Columns.Clear();
            dataGrid1.Columns.Add("time", "time");
            dataGrid1.Columns.Add("probablity", "probablity");
            dataGrid1.Columns.Add("cum_probablity", "cum_probablity");
            dataGrid1.Columns.Add("min", "min");
            dataGrid1.Columns.Add("max", "max");
            for (int i = 0; i < time_len; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                row.Cells[0].Value = dist_time[i].Time;
                row.Cells[1].Value = dist_time[i].Probability;
                row.Cells[2].Value = dist_time[i].CummProbability;
                row.Cells[3].Value = dist_time[i].MinRange;
                if (dist_time[i].MaxRange == 99)
                {
                    row.Cells[4].Value = 0;
                }
                else { row.Cells[4].Value = dist_time[i].MaxRange; }
                dataGrid1.Rows.Add(row);

            }

        }
        int server_len = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32(indx.Text);
            double sum = 0.0;
            double pro = 0.0;
            server_len = dataGrid1.Rows.Count - 1;
            
            TimeDistribution temp, best = new TimeDistribution(); ;
         //   MessageBox.Show(server.Length.ToString());
             server[idx-1] = new Server();
            for (int i = 0; i < dataGrid1.Rows.Count - 1; i++)
            {
                temp = new TimeDistribution();
                
                if (i == 0)
                {
                    server[idx - 1].ServerId = i;

                    if (dataGrid1.Rows[i].Cells[0].Value != null)
                    {
                        server[idx - 1].Name = dataGrid1.Rows[i].Cells[0].Value.ToString();
                    }
                    if (dataGrid1.Rows[i].Cells[1].Value != null)
                    {
                        server[idx - 1].ServiceEfficiency = Convert.ToDouble(dataGrid1.Rows[i].Cells[1].Value);
                    }
                }
                if (dataGrid1.Rows[i].Cells[2].Value != null)
                {
                    temp.Time = Convert.ToInt32(dataGrid1.Rows[i].Cells[2].Value);
                }

                if (dataGrid1.Rows[i].Cells[3].Value != null)
                {
                    temp.Probability = Convert.ToDouble(dataGrid1.Rows[i].Cells[3].Value);
                    pro = Convert.ToDouble(dataGrid1.Rows[i].Cells[3].Value) * 100;
                    sum += temp.Probability;
                    temp.CummProbability = sum;
                    if (i == 0)
                    {
                        temp.MinRange = 1;
                        temp.MaxRange = pro;
                    }
                    else
                    {
                        temp.MinRange = best.MaxRange + 1;
                        if (temp.MinRange + pro >= 100)
                        {
                            temp.MaxRange = 99;
                        }
                        else
                        {
                            temp.MaxRange = temp.MinRange + pro - 1;
                        }
                    }

                    best = temp;

                }
               // MessageBox.Show(dist_time[i].Time.ToString() + " " + dist_time[i].Probability.ToString() + " " + dist_time[i].CummProbability.ToString() + " " + dist_time[i].MinRange.ToString() + "   " + dist_time[i].MaxRange.ToString());
                server[idx-1].ServiceTimeDistribution.Add(temp);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32(indx.Text);
            dataGrid1.Columns.Clear();
            dataGrid1.Columns.Add("name", "name");
            dataGrid1.Columns.Add("efficency", "efficency");
            dataGrid1.Columns.Add("time", "time");
            dataGrid1.Columns.Add("probablity", "probablity");
            dataGrid1.Columns.Add("cum_probablity", "cum_probablity");
            dataGrid1.Columns.Add("max", "max");
            dataGrid1.Columns.Add("nin", "min");
            bool a = true;
            int k = 1;
            
            foreach (TimeDistribution temp in server[idx-1].ServiceTimeDistribution)
            {
                //MessageBox.Show(temp.Time.ToString() + " " + temp.Probability.ToString() + " " + temp.CummProbability.ToString() + " " + temp.MinRange.ToString() + "   " + temp.MaxRange.ToString());
                DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
               // MessageBox.Show(k.ToString());
                k++;
                if (a == true)
                {
                    
                    row.Cells[0].Value = server[idx-1].Name;
                    row.Cells[1].Value = server[idx-1].ServiceEfficiency;
                    
                    row.Cells[2].Value = temp.Time;
                    row.Cells[3].Value = temp.Probability;
                    row.Cells[4].Value = temp.CummProbability;
                    row.Cells[6].Value = temp.MinRange;
                    a = false;
                }
                else
                {
                    row.Cells[0].Value = "_";
                    row.Cells[1].Value = "_";
                    row.Cells[2].Value = temp.Time;
                    row.Cells[3].Value = temp.Probability;
                    row.Cells[4].Value = temp.CummProbability;
                    
                    row.Cells[6].Value = temp.MinRange;

                }

                if (temp.MaxRange == 99)
                {
                    row.Cells[5].Value = 0;
                }
                else { row.Cells[5].Value = temp.MaxRange; }
                dataGrid1.Rows.Add(row);

                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server = new Server[Convert.ToInt32(svnm.Text)];
            MessageBox.Show("servers number is " + svnm.Text);
            svnm.Visible = false;
            num_servers = Convert.ToInt32(svnm.Text);
            label1.Text = "Servers numder is " + svnm.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.Columns.Clear();
            panel1.Visible = !panel1.Visible;
            if (checkBox2.Checked)
            {
                dataGrid1.Columns.Add("name", "name");
                dataGrid1.Columns.Add("efficency", "efficency");
                dataGrid1.Columns.Add("time", "time");
                dataGrid1.Columns.Add("probablity", "probablity");
                dataGrid1.Columns.Add("cum_probablity", "cum_probablity");
                dataGrid1.Columns.Add("max", "max");
                dataGrid1.Columns.Add("nin", "min");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
            row.Cells[0].Value = name.Text;
            row.Cells[1].Value = eff.Text;
            row.Cells[2].Value = service.Text;
            row.Cells[3].Value = prop.Text;
            row.Cells[4].Value = 0;
            row.Cells[5].Value = 0;
            row.Cells[6].Value = 0;
            dataGrid1.Rows.Add(row);
            //double r = Convert.ToDouble(row.Cells[1].Value) * 100;
            /* if(dataGrid1.Rows[dataGrid1.Rows.Count-2].Cells[0].Value !=null)
             l.Text = dataGrid1.Rows[dataGrid1.Rows.Count-2].Cells[0].Value.ToString() ;
             */
            l.Text = dataGrid1.Rows.Count.ToString();
        }
        int newdata_len = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            dataGrid1.Columns.Clear();
            dataGrid1.Columns.Add("name", "custom_num");
            dataGrid1.Columns.Add("efficency", "randomDigitarrival");
            dataGrid1.Columns.Add("time", "timeBettweenarrival");
            dataGrid1.Columns.Add("probablity", "clocktime");
            dataGrid1.Columns.Add("cum_probablity", "randomdigitservice");
            dataGrid1.Columns.Add("max", "servername");
            dataGrid1.Columns.Add("nin", "timebegin");
            dataGrid1.Columns.Add("nin", "servicetime");
            dataGrid1.Columns.Add("nin", "timeend");
            dataGrid1.Columns.Add("nin", "timeinqueue");
       

            for (int i = 0; i < num_servers; i++)
            {
                server[i].ServerId = i;
            }
            if(users.Checked==true){
                if (servpri.Checked == true)
                {
                    Random rnd = new Random();
                    int card = rnd.Next(99);
                    

                    smulation[0] = new SimualtionCase();
                    smulation[0].CustomerNumber = 0 + 1;
                    smulation[0].RandomInterarrivalTime = -1;
                    smulation[0].InterarrivalTime = -1;
                    smulation[0].ArrivalTime = 0;
                    card = rnd.Next(99);
                   // card = 95;
                    smulation[0].RandomServiceTime = card;
                    if (card == 0)
                    {
                        smulation[0].ServiceTime = server[0].ServiceTimeDistribution[server[0].ServiceTimeDistribution.Count - 1].Time;
                        smulation[0].AssignedServer = server[0];
                    }
                    else
                    {
                        foreach (TimeDistribution temp in server[0].ServiceTimeDistribution)
                        {

                            if (card >= temp.MinRange && card <= temp.MaxRange)
                            {
                                smulation[0].ServiceTime = temp.Time;
                                smulation[0].AssignedServer = server[0];
                                break;
                            }
                        }
                    }
                    smulation[0].TimeServiceBegins = 0;
                    smulation[0].TimeServiceEnds = smulation[0].TimeServiceBegins + smulation[0].ServiceTime;
                    smulation[0].WaitingTime = smulation[0].TimeServiceBegins - 0;
                    
                    DataGridViewRow row1 = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                    row1.Cells[0].Value = smulation[0].CustomerNumber;
                    row1.Cells[1].Value = "_";
                    row1.Cells[2].Value = "_";
                    row1.Cells[3].Value = smulation[0].ArrivalTime;
                    row1.Cells[4].Value = smulation[0].RandomServiceTime;

                    row1.Cells[5].Value = smulation[0].AssignedServer.Name;
                    row1.Cells[6].Value = smulation[0].TimeServiceBegins;
                    row1.Cells[7].Value = smulation[0].ServiceTime;
                    row1.Cells[8].Value = smulation[0].TimeServiceEnds;
                    row1.Cells[9].Value = smulation[0].WaitingTime;
                    
                    dataGrid1.Rows.Add(row1);
                    int clock = 0;
                    int num_customers = Convert.ToInt32(part.Text);
                    for (int i = 1; i < num_customers; i++)
                    {
                        int arrivaltime = 0;
                        smulation[i] = new SimualtionCase();
                        smulation[i].CustomerNumber = i + 1;


                        /////////////// RANDOM FOR INTRE arri val
                        card = rnd.Next(0,99);
                        //if (i == 1) card = 26;
                        //if (i == 2) card = 98;
                        //if (i == 3) card = 90;
                        //if (i == 4) card = 26;
                        //if (i == 5) card = 42;
                        //if (i == 6) card = 74;
                        smulation[i].RandomInterarrivalTime = card;
                        for (int j = 0; j < time_len; j++)
                        {
                            if (card == 0)
                            {
                                arrivaltime = dist_time[time_len - 1].Time;
                                break;
                            }
                            else
                            {
                                if (card >= dist_time[j].MinRange && card <= dist_time[j].MaxRange)
                                {
                                    arrivaltime = dist_time[j].Time;
                                    break;
                                }
                            }
                        }
                        smulation[i].InterarrivalTime = arrivaltime;
                        clock += smulation[i].InterarrivalTime;
                        smulation[i].ArrivalTime = clock;
                        /////////////////////////////////////////
                        ///////////////busyserers/////////////////////////////////////
                        List<int> emptyservers = new List<int>();
                        List<int> busyservers = new List<int>();
                        for (int u = i - 1; u >= 0; u--)
                        {
                            if (clock < smulation[u].TimeServiceEnds)
                            {

                                busyservers.Add(smulation[u].AssignedServer.ServerId);

                            }
                        }
                        bool mogd = true;
                        for (int dd = 0; dd < num_servers; dd++)
                        {
                            mogd = true;
                            if (busyservers.Count > 0)
                            {
                                for (int ss = 0; ss < busyservers.Count; ss++)
                                {
                                    if (dd == busyservers[ss])
                                    {
                                        mogd = false;
                                        break;
                                    }
                                }
                                if (mogd == true)
                                {
                                    emptyservers.Add(dd);
                                }
                            }
                            else
                            {
                                emptyservers.Add(dd);
                            }
                        }


                        ///////////////////////////
                        //////////////////////countempty >0///////////////
                        if (emptyservers.Count > 0)
                        {
                            emptyservers.Sort();
                            card = rnd.Next(99);
                            //if (i == 1) card = 21;
                            //if (i == 2) card = 51;
                            //if (i == 3) card = 92;
                            //if (i == 4) card = 89;
                            //if (i == 5) card = 38;
                            //if (i == 6) card = 13;
                            smulation[i].RandomServiceTime = card;
                            if (card == 0)
                            {
                                smulation[i].ServiceTime = server[emptyservers[0]].ServiceTimeDistribution[server[emptyservers[0]].ServiceTimeDistribution.Count - 1].Time;
                                smulation[i].AssignedServer = server[emptyservers[0]];

                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[emptyservers[0]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[i].ServiceTime = temp.Time;

                                        smulation[i].AssignedServer = server[emptyservers[0]];
                                        break;
                                    }
                                }
                            }

                            smulation[i].TimeServiceBegins = clock;
                            smulation[i].TimeServiceEnds = smulation[i].TimeServiceBegins + smulation[i].ServiceTime;
                            smulation[i].WaitingTime = smulation[i].TimeServiceBegins - clock;
                           

                        }//emptyservers.Count>0
                        ////////////////////////else empty
                        else
                        {
                            int id = 0;
                            int minn = 1000;
                            int dif = 0;
                            for (int u = i - 1; u >= 0; u--)
                            {
                                if (clock < smulation[u].TimeServiceEnds)
                                {
                                    dif = smulation[u].TimeServiceEnds - clock;
                                    if (dif <= minn)
                                    {
                                        minn = dif;
                                        
                                        
                                            id = smulation[u].AssignedServer.ServerId;
                                    }
                                    if (dif == minn)
                                        {
                                            if (smulation[u].AssignedServer.ServerId <= id) id = smulation[u].AssignedServer.ServerId;
                                        }
                                }
                            }
                              card = rnd.Next(99);
                            smulation[i].RandomServiceTime = card;

                            if (card == 0)
                            {
                                smulation[i].ServiceTime = server[id].ServiceTimeDistribution[server[id].ServiceTimeDistribution.Count - 1].Time;
                                smulation[i].AssignedServer = server[busyservers[id]];

                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[busyservers[id]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[i].ServiceTime = temp.Time;

                                        smulation[i].AssignedServer = server[id];
                                        break;
                                    }
                                }
                            }

                            smulation[i].TimeServiceBegins = clock + minn;
                            smulation[i].TimeServiceEnds = smulation[i].TimeServiceBegins + smulation[i].ServiceTime;
                            smulation[i].WaitingTime = minn;
                            
                        }//emptyservers.Count==0
                        ////////////////////gridview
                        DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row.Cells[0].Value = smulation[i].CustomerNumber;
                        row.Cells[1].Value = smulation[i].RandomInterarrivalTime;
                        row.Cells[2].Value = smulation[i].InterarrivalTime;
                        row.Cells[3].Value = smulation[i].ArrivalTime;
                        row.Cells[4].Value = smulation[i].RandomServiceTime;
                        row.Cells[5].Value = smulation[i].AssignedServer.Name;
                        row.Cells[6].Value = smulation[i].TimeServiceBegins;
                        row.Cells[7].Value = smulation[i].ServiceTime;
                        row.Cells[8].Value = smulation[i].TimeServiceEnds;
                        row.Cells[9].Value = smulation[i].WaitingTime;
                        
                        dataGrid1.Rows.Add(row);
                        emptyservers.Clear();
                        busyservers.Clear();
                    }//CUSTOM



                }//priority

////////////////////////////////////////////////////random begin


                if (randserv.Checked == true)
                {
                    Random rnd = new Random();
                    int card = rnd.Next(99);
                    int[] arr = new int[num_servers];
                    for (int i = 0; i < num_servers; i++)
                    {
                        server[i].ServerId = i;
                        arr[i] = i;
                    }

                    smulation[0] = new SimualtionCase();
                    smulation[0].CustomerNumber = 0 + 1;

                    smulation[0].RandomInterarrivalTime = -1;
                    smulation[0].InterarrivalTime = -1;
                    smulation[0].ArrivalTime = 0;
                      card = rnd.Next(99);
                    
                   int card2 = rnd.Next(0, num_servers - 1);
                    smulation[0].RandomServiceTime = card;
                    if (card == 0)
                    {
                        smulation[0].ServiceTime = server[card2].ServiceTimeDistribution[server[card2].ServiceTimeDistribution.Count - 1].Time;
                        smulation[0].AssignedServer = server[card2];
                    }
                    else
                    {
                        foreach (TimeDistribution temp in server[card2].ServiceTimeDistribution)
                        {

                            if (card >= temp.MinRange && card <= temp.MaxRange)
                            {
                                smulation[0].ServiceTime = temp.Time;
                                smulation[0].AssignedServer = server[card2];
                                break;
                            }
                        }
                    }
                    smulation[0].TimeServiceBegins = 0;
                    smulation[0].TimeServiceEnds = smulation[0].TimeServiceBegins + smulation[0].ServiceTime;
                    smulation[0].WaitingTime = smulation[0].TimeServiceBegins - 0;
                    
                    DataGridViewRow row1 = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                    row1.Cells[0].Value = smulation[0].CustomerNumber;
                    row1.Cells[1].Value = "_";
                    row1.Cells[2].Value = "_";
                    row1.Cells[3].Value = smulation[0].ArrivalTime;
                    row1.Cells[4].Value = smulation[0].RandomServiceTime;
                    row1.Cells[5].Value = smulation[0].AssignedServer.Name;
                    row1.Cells[6].Value = smulation[0].TimeServiceBegins;
                    row1.Cells[7].Value = smulation[0].ServiceTime;
                    row1.Cells[8].Value = smulation[0].TimeServiceEnds;
                    row1.Cells[9].Value = smulation[0].WaitingTime;
                    
                    dataGrid1.Rows.Add(row1);
                    //////////////////////////////////////////////
                    int clock = 0;
                    int num_customers = Convert.ToInt32(part.Text);
                    for (int i = 1; i < num_customers; i++)
                    {
                        int arrivaltime = 0;
                        smulation[i] = new SimualtionCase();
                        smulation[i].CustomerNumber = i + 1;
                        ///////////////////////random intervial
                        card = rnd.Next(0, 99);
     
                        smulation[i].RandomInterarrivalTime = card;
                        for (int j = 0; j < time_len; j++)
                        {
                            if (card == 0)
                            {
                                arrivaltime = dist_time[time_len - 1].Time;
                                break;
                            }
                            else
                            {
                                if (card >= dist_time[j].MinRange && card <= dist_time[j].MaxRange)
                                {
                                    arrivaltime = dist_time[j].Time;
                                    break;
                                }
                            }
                        }
                        smulation[i].InterarrivalTime = arrivaltime;
                        clock += smulation[i].InterarrivalTime;
                        smulation[i].ArrivalTime = clock;

                        ////////////////////end of randomm interal
                        ///////////////random busyserers/////////////////////////////////////
                        List<int> emptyservers = new List<int>();
                        List<int> busyservers = new List<int>();
                        for (int u = i - 1; u >= 0; u--)
                        {
                            if (clock < smulation[u].TimeServiceEnds)
                            {

                                busyservers.Add(smulation[u].AssignedServer.ServerId);

                            }
                        }
                        bool mogd = true;
                        for (int dd = 0; dd < num_servers; dd++)
                        {
                            mogd = true;
                            if (busyservers.Count > 0)
                            {
                                for (int ss = 0; ss < busyservers.Count; ss++)
                                {
                                    if (dd == busyservers[ss])
                                    {
                                        mogd = false;
                                        break;
                                    }
                                }
                                if (mogd == true)
                                {
                                    emptyservers.Add(dd);
                                }
                            }
                            else
                            {
                                emptyservers.Add(dd);
                            }
                        }


                        ///////////////////////////end of random bussy server
                        //////////////////////countempty >0///////////////
                        if (emptyservers.Count > 0)
                        {
                            emptyservers.Sort();
                            card = rnd.Next(99);
                            //if (i == 1) card = 21;
                            //if (i == 2) card = 51;
                            //if (i == 3) card = 92;
                            //if (i == 4) card = 89;
                            //if (i == 5) card = 38;
                            //if (i == 6) card = 13;
                            smulation[i].RandomServiceTime = card;                           
                            card2 = rnd.Next(0, emptyservers.Count );
                            if (card == 0)
                            {
                                smulation[i].ServiceTime = server[emptyservers[card2]].ServiceTimeDistribution[server[emptyservers[card2]].ServiceTimeDistribution.Count - 1].Time;
                                smulation[i].AssignedServer = server[emptyservers[card2]];
                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[emptyservers[card2]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[i].ServiceTime = temp.Time;

                                        smulation[i].AssignedServer = server[emptyservers[card2]];
                                        break;
                                    }
                                }
                            }

                            smulation[i].TimeServiceBegins = clock;
                            smulation[i].TimeServiceEnds = smulation[i].TimeServiceBegins + smulation[i].ServiceTime;
                            smulation[i].WaitingTime = smulation[i].TimeServiceBegins - clock;
                            
                        }//emptyservers.Count>0

                        else
                        {
                            int id = 0;
                            int minn = 1000;
                            int dif = 0;
                            List<int> star = new List<int>();
                            for (int u = i - 1; u >= 0; u--)
                            {
                                if (clock <= smulation[u].TimeServiceEnds)
                                {
                                    dif = smulation[u].TimeServiceEnds - clock;
                                    if (dif < minn)
                                    {
                                        minn = dif;
                                        
                                        
                                            id = smulation[u].AssignedServer.ServerId;
                                    }
                                    if (dif == minn)
                                        {
                                             star.Add(smulation[u].AssignedServer.ServerId);
                                             star.Add(id);
                                        }
                                }
                            }
                             card = rnd.Next(99);
                            //if (i == 1) card = 21;
                            //if (i == 2) card = 51;
                            //if (i == 3) card = 92;
                            //if (i == 4) card = 89;
                            //if (i == 5) card = 38;
                            //if (i == 6) card = 13;
                            smulation[i].RandomServiceTime = card;
                            if (star.Count > 0) 
                            {
                                card2 = rnd.Next(0, star.Count - 1);
                                id = star[card2];
 
                            }
                            if (card == 0)
                            {
                                smulation[i].ServiceTime = server[id].ServiceTimeDistribution[server[id].ServiceTimeDistribution.Count - 1].Time;
                                smulation[i].AssignedServer = server[busyservers[id]];

                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[busyservers[id]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[i].ServiceTime = temp.Time;

                                        smulation[i].AssignedServer = server[id];
                                        break;
                                    }
                                }
                            }

                            smulation[i].TimeServiceBegins = clock + minn;
                            smulation[i].TimeServiceEnds = smulation[i].TimeServiceBegins + smulation[i].ServiceTime;
                            smulation[i].WaitingTime = minn;
                            
                        }//emptyservers.Count==0

                        DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row.Cells[0].Value = smulation[i].CustomerNumber;
                        row.Cells[1].Value = smulation[i].RandomInterarrivalTime;
                        row.Cells[2].Value = smulation[i].InterarrivalTime;
                        row.Cells[3].Value = smulation[i].ArrivalTime;
                        row.Cells[4].Value = smulation[i].RandomServiceTime;
                        row.Cells[5].Value = smulation[i].AssignedServer.Name;
                        row.Cells[6].Value = smulation[i].TimeServiceBegins;
                        row.Cells[7].Value = smulation[i].ServiceTime;
                        row.Cells[8].Value = smulation[i].TimeServiceEnds;
                        row.Cells[9].Value = smulation[i].WaitingTime;
                       
                        dataGrid1.Rows.Add(row);
                        emptyservers.Clear();
                        busyservers.Clear();

                    }// customerrrrrrrrr

                    


                }// random












            }//users
            //////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ttttttthourssss
            else if (hours.Checked==true)
            {
                if (servpri.Checked == true)
                {
                    Random rnd = new Random();
                    int card = rnd.Next(99);
                    for (int i = 0; i < num_servers; i++)
                    {
                        server[i].ServerId = i;
                    }

                    smulation[0] = new SimualtionCase();
                    smulation[0].CustomerNumber = 0 + 1;
                    smulation[0].RandomInterarrivalTime = -1;
                    smulation[0].InterarrivalTime = -1;
                    smulation[0].ArrivalTime = 0;
                    card = rnd.Next(99);
                    // card = 95;
                    smulation[0].RandomServiceTime = card;
                    if (card == 0)
                    {
                        smulation[0].ServiceTime = server[0].ServiceTimeDistribution[server[0].ServiceTimeDistribution.Count - 1].Time;
                        smulation[0].AssignedServer = server[0];
                    }
                    else
                    {
                        foreach (TimeDistribution temp in server[0].ServiceTimeDistribution)
                        {

                            if (card >= temp.MinRange && card <= temp.MaxRange)
                            {
                                smulation[0].ServiceTime = temp.Time;
                                smulation[0].AssignedServer = server[0];
                                break;
                            }
                        }
                    }
                    smulation[0].TimeServiceBegins = 0;
                    smulation[0].TimeServiceEnds = smulation[0].TimeServiceBegins + smulation[0].ServiceTime;
                    smulation[0].WaitingTime = smulation[0].TimeServiceBegins - 0;
                   
                    int hours1 = Convert.ToInt32(part.Text);
                    if (hours1 >= smulation[0].TimeServiceEnds)
                    {


                        DataGridViewRow row1 = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row1.Cells[0].Value = smulation[0].CustomerNumber;
                        row1.Cells[1].Value = "_";
                        row1.Cells[2].Value = "_";
                        row1.Cells[3].Value = smulation[0].ArrivalTime;
                        row1.Cells[4].Value = smulation[0].RandomServiceTime;

                        row1.Cells[5].Value = smulation[0].AssignedServer.Name;
                        row1.Cells[6].Value = smulation[0].TimeServiceBegins;
                        row1.Cells[7].Value = smulation[0].ServiceTime;
                        row1.Cells[8].Value = smulation[0].TimeServiceEnds;
                        row1.Cells[9].Value = smulation[0].WaitingTime;
                        
                        dataGrid1.Rows.Add(row1);
                    }
                    int clock = 0;
                    int ii=1;
                    while(true)
                    {
                        int arrivaltime = 0;
                        smulation[ii] = new SimualtionCase();
                        smulation[ii].CustomerNumber = ii + 1;
                        card = rnd.Next(0, 99);
                        smulation[ii].RandomInterarrivalTime = card;
                        for (int j = 0; j < time_len; j++)
                        {
                            if (card == 0)
                            {
                                arrivaltime = dist_time[time_len - 1].Time;
                                break;
                            }
                            else
                            {
                                if (card >= dist_time[j].MinRange && card <= dist_time[j].MaxRange)
                                {
                                    arrivaltime = dist_time[j].Time;
                                    break;
                                }
                            }
                        }
                        smulation[ii].InterarrivalTime = arrivaltime;
                        clock += smulation[ii].InterarrivalTime;
                        smulation[ii].ArrivalTime = clock;
                        ///////////////busyserers/////////////////////////////////////
                        List<int> emptyservers = new List<int>();
                        List<int> busyservers = new List<int>();
                        for (int u = ii - 1; u >= 0; u--)
                        {
                            if (clock < smulation[u].TimeServiceEnds)
                            {

                                busyservers.Add(smulation[u].AssignedServer.ServerId);

                            }
                        }
                        bool mogd = true;
                        for (int dd = 0; dd < num_servers; dd++)
                        {
                            mogd = true;
                            if (busyservers.Count > 0)
                            {
                                for (int ss = 0; ss < busyservers.Count; ss++)
                                {
                                    if (dd == busyservers[ss])
                                    {
                                        mogd = false;
                                        break;
                                    }
                                }
                                if (mogd == true)
                                {
                                    emptyservers.Add(dd);
                                }
                            }
                            else
                            {
                                emptyservers.Add(dd);
                            }
                        }


                        ///////////////////////////
                        //////////////////////countempty >0///////////////
                        if (emptyservers.Count > 0)
                        {
                            emptyservers.Sort();
                            card = rnd.Next(99);
                            smulation[ii].RandomServiceTime = card;
                            if (card == 0)
                            {
                                smulation[ii].ServiceTime = server[emptyservers[0]].ServiceTimeDistribution[server[emptyservers[0]].ServiceTimeDistribution.Count - 1].Time;
                                smulation[ii].AssignedServer = server[emptyservers[0]];
                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[emptyservers[0]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[ii].ServiceTime = temp.Time;

                                        smulation[ii].AssignedServer = server[emptyservers[0]];
                                        break;
                                    }
                                }
                            }

                            smulation[ii].TimeServiceBegins = clock;
                            smulation[ii].TimeServiceEnds = smulation[ii].TimeServiceBegins + smulation[ii].ServiceTime;
                            smulation[ii].WaitingTime = smulation[ii].TimeServiceBegins - clock;
                           
                            if (hours1 <= smulation[ii].TimeServiceEnds) break;

                        }//emptyservers.Count>0
                        ////////////////////////else empty
                        else
                        {
                            int id = 0;
                            int minn = 1000;
                            int dif = 0;
                            for (int u = ii - 1; u >= 0; u--)
                            {
                                if (clock <= smulation[u].TimeServiceEnds)
                                {
                                    dif = smulation[u].TimeServiceEnds - clock;
                                    if (dif < minn)
                                    {
                                        minn = dif;
                                        
                                        
                                            id = smulation[u].AssignedServer.ServerId;
                                    }
                                    if (dif == minn)
                                        {
                                            if (smulation[u].AssignedServer.ServerId <= id) id = smulation[u].AssignedServer.ServerId;
                                        }
                                }
                            }
                            card = rnd.Next(99);
                            smulation[ii].RandomServiceTime = card;

                            if (card == 0)
                            {
                                smulation[ii].ServiceTime = server[id].ServiceTimeDistribution[server[id].ServiceTimeDistribution.Count - 1].Time;
                                smulation[ii].AssignedServer = server[busyservers[id]];

                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[busyservers[id]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[ii].ServiceTime = temp.Time;

                                        smulation[ii].AssignedServer = server[id];
                                        break;
                                    }
                                }
                            }

                            smulation[ii].TimeServiceBegins = clock + minn;
                            smulation[ii].TimeServiceEnds = smulation[ii].TimeServiceBegins + smulation[ii].ServiceTime;
                            smulation[ii].WaitingTime = minn;
                            
                            if (hours1 <= smulation[ii].TimeServiceEnds) break;
                        }//emptyservers.Count==0
                        ////////////////////gridview
                        DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row.Cells[0].Value = smulation[ii].CustomerNumber;
                        row.Cells[1].Value = smulation[ii].RandomInterarrivalTime;
                        row.Cells[2].Value = smulation[ii].InterarrivalTime;
                        row.Cells[3].Value = smulation[ii].ArrivalTime;
                        row.Cells[4].Value = smulation[ii].RandomServiceTime;
                        row.Cells[5].Value = smulation[ii].AssignedServer.Name;
                        row.Cells[6].Value = smulation[ii].TimeServiceBegins;
                        row.Cells[7].Value = smulation[ii].ServiceTime;
                        row.Cells[8].Value = smulation[ii].TimeServiceEnds;
                        row.Cells[9].Value = smulation[ii].WaitingTime;
                        
                        dataGrid1.Rows.Add(row);
                        emptyservers.Clear();
                        busyservers.Clear();
                        ii++;
                    }//CUSTOM



                }//priority

                if (randserv.Checked == true)
                {
                    Random rnd = new Random();
                    int card = rnd.Next(99);
                    int[] arr = new int[num_servers];
                    for (int i = 0; i < num_servers; i++)
                    {
                        server[i].ServerId = i;
                        arr[i] = i;
                    }

                    smulation[0] = new SimualtionCase();
                    smulation[0].CustomerNumber = 0 + 1;

                    smulation[0].RandomInterarrivalTime = -1;
                    smulation[0].InterarrivalTime = -1;
                    smulation[0].ArrivalTime = 0;
                    card = rnd.Next(99);

                    int card2 = rnd.Next(0, num_servers - 1);
                    smulation[0].RandomServiceTime = card;
                    if (card == 0)
                    {
                        smulation[0].ServiceTime = server[card2].ServiceTimeDistribution[server[card2].ServiceTimeDistribution.Count - 1].Time;
                        smulation[0].AssignedServer = server[card2];
                    }
                    else
                    {
                        foreach (TimeDistribution temp in server[card2].ServiceTimeDistribution)
                        {

                            if (card >= temp.MinRange && card <= temp.MaxRange)
                            {
                                smulation[0].ServiceTime = temp.Time;
                                smulation[0].AssignedServer = server[card2];
                                break;
                            }
                        }
                    }
                    int hours1 = Convert.ToInt32(part.Text);
                    smulation[0].TimeServiceBegins = 0;
                    smulation[0].TimeServiceEnds = smulation[0].TimeServiceBegins + smulation[0].ServiceTime;
                    smulation[0].WaitingTime = smulation[0].TimeServiceBegins - 0;
                    
                    if (hours1 >= smulation[0].TimeServiceEnds)
                    {

                        DataGridViewRow row1 = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row1.Cells[0].Value = smulation[0].CustomerNumber;
                        row1.Cells[1].Value = "_";
                        row1.Cells[2].Value = "_";
                        row1.Cells[3].Value = smulation[0].ArrivalTime;
                        row1.Cells[4].Value = smulation[0].RandomServiceTime;
                        row1.Cells[5].Value = smulation[0].AssignedServer.Name;
                        row1.Cells[6].Value = smulation[0].TimeServiceBegins;
                        row1.Cells[7].Value = smulation[0].ServiceTime;
                        row1.Cells[8].Value = smulation[0].TimeServiceEnds;
                        row1.Cells[9].Value = smulation[0].WaitingTime;
                        
                        dataGrid1.Rows.Add(row1);
                    }
                    //////////////////////////////////////////////
                    int clock = 0;
                    int ii=1;
                    while(true)
                    {
                        int arrivaltime = 0;
                        smulation[ii] = new SimualtionCase();
                        smulation[ii].CustomerNumber = ii + 1;
                        ///////////////////////random intervial
                        card = rnd.Next(0, 99);
                        smulation[ii].RandomInterarrivalTime = card;
                        for (int j = 0; j < time_len; j++)
                        {
                            if (card == 0)
                            {
                                arrivaltime = dist_time[time_len - 1].Time;
                                break;
                            }
                            else
                            {
                                if (card >= dist_time[j].MinRange && card <= dist_time[j].MaxRange)
                                {
                                    arrivaltime = dist_time[j].Time;
                                    break;
                                }
                            }
                        }
                        smulation[ii].InterarrivalTime = arrivaltime;
                        clock += smulation[ii].InterarrivalTime;
                        smulation[ii].ArrivalTime = clock;
                        ////////////////////end of randomm interal
                        ///////////////random busyserers/////////////////////////////////////
                        List<int> emptyservers = new List<int>();
                        List<int> busyservers = new List<int>();
                        for (int u = ii - 1; u >= 0; u--)
                        {
                            if (clock < smulation[u].TimeServiceEnds)
                            {

                                busyservers.Add(smulation[u].AssignedServer.ServerId);

                            }
                        }
                        bool mogd = true;
                        for (int dd = 0; dd < num_servers; dd++)
                        {
                            mogd = true;
                            if (busyservers.Count > 0)
                            {
                                for (int ss = 0; ss < busyservers.Count; ss++)
                                {
                                    if (dd == busyservers[ss])
                                    {
                                        mogd = false;
                                        break;
                                    }
                                }
                                if (mogd == true)
                                {
                                    emptyservers.Add(dd);
                                }
                            }
                            else
                            {
                                emptyservers.Add(dd);
                            }
                        }
                        ///////////////////////////end of random bussy server
                        //////////////////////countempty >0///////////////
                        if (emptyservers.Count > 0)
                        {
                            emptyservers.Sort();
                            card = rnd.Next(99);
                            smulation[ii].RandomServiceTime = card;
                            card2 = rnd.Next(0, emptyservers.Count);
                            if (card == 0)
                            {
                                smulation[ii].ServiceTime = server[emptyservers[card2]].ServiceTimeDistribution[server[emptyservers[card2]].ServiceTimeDistribution.Count - 1].Time;
                                smulation[ii].AssignedServer = server[emptyservers[card2]];
                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[emptyservers[card2]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[ii].ServiceTime = temp.Time;

                                        smulation[ii].AssignedServer = server[emptyservers[card2]];
                                        break;
                                    }
                                }
                            }

                            smulation[ii].TimeServiceBegins = clock;
                            smulation[ii].TimeServiceEnds = smulation[ii].TimeServiceBegins + smulation[ii].ServiceTime;
                            smulation[ii].WaitingTime = smulation[ii].TimeServiceBegins - clock;
                            
                            if (hours1 <= smulation[ii].TimeServiceEnds) break;

                        }//emptyservers.Count>0

                        else
                        {
                            int id = 0;
                            int minn = 1000;
                            int dif = 0;
                            List<int> star = new List<int>();
                            for (int u = ii - 1; u >= 0; u--)
                            {
                                if (clock <= smulation[u].TimeServiceEnds)
                                {
                                    dif = smulation[u].TimeServiceEnds - clock;
                                    if (dif < minn)
                                    {
                                        minn = dif;

                                        id = smulation[u].AssignedServer.ServerId;
                                    }
                                    if (dif == minn)
                                    {
                                        star.Add(smulation[u].AssignedServer.ServerId);
                                        star.Add(id);
                                    }
                                }
                            }
                            card = rnd.Next(99);
                            smulation[ii].RandomServiceTime = card;
                            if (star.Count > 0)
                            {
                                card2 = rnd.Next(0, star.Count - 1);
                                id = star[card2];

                            }
                            if (card == 0)
                            {
                                smulation[ii].ServiceTime = server[id].ServiceTimeDistribution[server[id].ServiceTimeDistribution.Count - 1].Time;
                                smulation[ii].AssignedServer = server[busyservers[id]];

                            }
                            else
                            {
                                foreach (TimeDistribution temp in server[busyservers[id]].ServiceTimeDistribution)
                                {
                                    if (card >= temp.MinRange && card <= temp.MaxRange)
                                    {
                                        smulation[ii].ServiceTime = temp.Time;

                                        smulation[ii].AssignedServer = server[id];
                                        break;
                                    }
                                }
                            }

                            smulation[ii].TimeServiceBegins = clock + minn;
                            smulation[ii].TimeServiceEnds = smulation[ii].TimeServiceBegins + smulation[ii].ServiceTime;
                            smulation[ii].WaitingTime = minn;
                            
                            if (hours1 <= smulation[ii].TimeServiceEnds) break;
                        }//emptyservers.Count==0

                        DataGridViewRow row = (DataGridViewRow)dataGrid1.Rows[0].Clone();
                        row.Cells[0].Value = smulation[ii].CustomerNumber;
                        row.Cells[1].Value = smulation[ii].RandomInterarrivalTime;
                        row.Cells[2].Value = smulation[ii].InterarrivalTime;
                        row.Cells[3].Value = smulation[ii].ArrivalTime;
                        row.Cells[4].Value = smulation[ii].RandomServiceTime;
                        row.Cells[5].Value = smulation[ii].AssignedServer.Name;
                        row.Cells[6].Value = smulation[ii].TimeServiceBegins;
                        row.Cells[7].Value = smulation[ii].ServiceTime;
                        row.Cells[8].Value = smulation[ii].TimeServiceEnds;
                        row.Cells[9].Value = smulation[ii].WaitingTime;
                        
                        dataGrid1.Rows.Add(row);
                        emptyservers.Clear();
                        busyservers.Clear();
                        ii++;
                    }// customerrrrrrrrr




                }// random




















            }//hours

            //////////////



            newdata_len = dataGrid1.Rows.Count - 1;
            MessageBox.Show(newdata_len.ToString());

        }//button
        
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "hoursnumber";
            part.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            part.Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            dataGrid1.Columns.Clear();
              dataGrid1.Columns.Add("name", "name");
                dataGrid1.Columns.Add("efficency", "efficency");
                dataGrid1.Columns.Add("time", "time");
                dataGrid1.Columns.Add("probablity", "probablity");
                dataGrid1.Columns.Add("cum_probablity", "cum_probablity");
                dataGrid1.Columns.Add("max", "max");
                dataGrid1.Columns.Add("nin", "min");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridout.Columns.Clear();
            gridout.Columns.Add("efficency", "averagewaitingtime");
            gridout.Columns.Add("time", "probabilitywait");
            gridout.Columns.Add("probablity", "averageservertime");
            int id = Convert.ToInt32(big.Text);
            int totalservicetim = 0;
            int totaltimewait = 0;

            int numw=0;
            int nums = 0;
            for (int i = 0; i < newdata_len; i++) 
            {
                

                if (smulation[i].AssignedServer.ServerId == id-1)
                {
                    totalservicetim += smulation[i].ServiceTime;

                    MessageBox.Show(i.ToString() + " " + smulation[i].ServiceTime.ToString());
                    nums += 1;
                }
                if (smulation[i].WaitingTime> 0)
                {
                    totaltimewait += smulation[i].WaitingTime;
                    numw+=1;
                }
                

            }

            double averagewaiting = (double)totaltimewait / (double)numw;
            //MessageBox.Show(nums.ToString());
            double probwaiting = (double)numw / (double)newdata_len;
            double averageserver = (double)totalservicetim / (double)nums;
            DataGridViewRow row = (DataGridViewRow)gridout.Rows[0].Clone();
            row.Cells[0].Value = averagewaiting ;
            row.Cells[1].Value = probwaiting;
            row.Cells[2].Value = averageserver;
            gridout.Rows.Add(row);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            dataGrid1.Visible = false;
            //int z = smulation[newdata_len - 1].TimeServiceEnds;
            //int[] arr = new int[z+1];
            //for (int i = 0; i <= z; i++)
            //{
            //    arr[i] = i;
            //}

            int serveum = Convert.ToInt32(big.Text) - 1;
            for (int i = 0; i < newdata_len; i++)
            {
                if (smulation[i].AssignedServer.ServerId == serveum)
                {

                    int x = smulation[i].TimeServiceBegins, y = smulation[i].TimeServiceEnds;
                    for (int z = x; z <= y; z++)
                    {
                        chart1.Series["server"].Points.AddXY(z, 1);


                    }


                }

            }
            


        }
    }

}
