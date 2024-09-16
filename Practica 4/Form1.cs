namespace Practica_5
{
    public partial class Form1 : Form
    {
        List<Proceso> procesosNuevosLst = new List<Proceso>();
        private void fifo(List<Proceso> lista)
        {
            //Creamos objeto fifo
            Fifo fifo = new Fifo();
            var fifoItems = fifo.ejecutarFifo(lista);
            fifoBox.Items.Clear();
            foreach (var obj in fifoItems)
            {
                fifoBox.Items.Add($"{obj.nombre} Inicio {obj.inicio} Final {obj.final}");
            }
        }

        private void Sjf(List<Proceso> lista)
        {
            //Creamos objeto Sjf
            Sjf sjf = new Sjf();
            var sjfList = sjf.ejecutarSjf(lista);
            sjfBox.Items.Clear();
            foreach (var obj in sjfList)
            {
                sjfBox.Items.Add($"{obj.nombre} Tiempo {obj.tiempo} Inicio {obj.inicio} Final {obj.final}");
            }
        }
        private void prioridades(List<Proceso> lista)
        {
            //Creamos objeto Prioridad
            Prioridades pri = new Prioridades();
            var priList = pri.ejecutarPrioridad(lista);
            prioridadesBox.Items.Clear();
            foreach (var obj in priList)
            {
                prioridadesBox.Items.Add($"{obj.nombre} Prioridad {obj.prioridad} Inicio {obj.inicio} Final {obj.final}");
            }
        }

        private void roundRobin(List<Proceso> lista)
        {
            //Creamos objeto Round Robin
            var procesosRR = lista;
            foreach (var obj in procesosRR)
            {
                obj.inicio = 0;
                obj.final = 0;
                obj.restante = obj.tiempo;
            }
            int round = 1;
            int quantum = 3;
            int tiempo = 0;
            rrBox.Items.Clear();
            while (procesosRR.Any(p => p.restante > 0))
            {
                rrBox.Items.Add($"Ronda {round}");
                foreach (var pr in procesosRR.Where(p => p.restante > 0))
                {
                    if (pr.restante > quantum)
                    {
                        pr.inicio = tiempo;
                        pr.restante -= quantum;
                        pr.final += quantum;
                        tiempo += quantum;
                    }
                    else
                    {
                        pr.inicio = tiempo;
                        tiempo += pr.restante;
                        pr.final += tiempo;
                        pr.restante -= pr.restante;

                    }
                    if (pr.restante == 0)
                    {
                        rrBox.Items.Add($"{pr.nombre} Tiempo inicio {pr.inicio} Tiempo final {pr.final}");
                    }
                    else
                    {
                        rrBox.Items.Add($"{pr.nombre} Tiempo inicio {pr.inicio} Tiempo restante {pr.restante}");
                    }

                }
                round++;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //Cargamos el archivo de procesos
            Proceso proceso = new Proceso();
            List<Proceso> procesosLst = new List<Proceso>();
            //Guardamos lista de procesos
            procesosLst = proceso.cargarProcesos("C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 5\\procesos.txt");
            procesosNuevosLst = proceso.cargarProcesos("C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 5\\procesos.txt");
            foreach (var obj in procesosLst)
            {
                fileBox.Items.Add($"Proceso {obj.nombre}, Tiempo {obj.tiempo}, Prioridad {obj.prioridad}");
            }
            //Creamos objeto fifo
            Fifo fifoObj = new Fifo();
            var procesosFifo = procesosLst;
            fifo(procesosFifo);
            //Creamos objeto Sjf
            Sjf sjf = new Sjf();
            var procesosSjf = procesosLst;
            Sjf(procesosSjf);
            //Creamos objeto Prioridad
            Prioridades pri = new Prioridades();
            var procesosList = procesosLst;
            prioridades(procesosList);
            //Creamos objeto Round Robin
            var procesosRR = procesosLst;
           roundRobin(procesosRR);
        }
        private void procesar_Click(object sender, EventArgs e)
        {
            if (nombreBox.Text == null || tiempoBox.Text == null || prioridadBox.Text == null || posicionBox.SelectedItem == null ||procesoBox.SelectedItem == null)
            {
                return;
            }
            Proceso procesoNew = new Proceso();
            procesoNew.nombre = nombreBox.Text;
            procesoNew.prioridad = int.Parse(prioridadBox.Text);
            procesoNew.tiempo = int.Parse(tiempoBox.Text);
            procesoNew.restante = int.Parse(tiempoBox.Text);
            procesoNew.final = 0;
            procesoNew.inicio = 0;
            switch (posicionBox.SelectedItem)
            {
                case "Inicio":
                    procesosNuevosLst.Insert(0, procesoNew);
                    break;
                case "Final":
                    procesosNuevosLst.Add(procesoNew);
                    break;
            }
            procesosNuevosBox.Items.Clear();
            foreach(var obj in procesosNuevosLst)
            {
                procesosNuevosBox.Items.Add($"{obj.nombre} Tiempo {obj.tiempo} Prioridad {obj.prioridad}");
            }
            switch (procesoBox.SelectedItem)
            {
                case "Fifo":
                    fifo(procesosNuevosLst);
                    break;
                case "Sjf":
                    Sjf(procesosNuevosLst);
                    break;
                case "Prioridades":
                    prioridades(procesosNuevosLst);
                    break;
                case "Round robin":
                    roundRobin(procesosNuevosLst);
                    break;
            }
        }
    }
}
