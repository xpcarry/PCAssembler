using PCAssembler.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAssembler
{
    public partial class Form1 : Form
    {
        private readonly Composite _list;
        Assembler assembler = new Assembler();
        PerformanceIndicator performanceInd = new PerformanceIndicator();
        PriceIndicator priceInd = new PriceIndicator();


        public Form1(Composite list)
        {
            _list = list;
            assembler.AddObserver(performanceInd);
            assembler.AddObserver(priceInd);
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(_list.GetNamesByType("Procesor"));
            comboBox2.Items.AddRange(_list.GetNamesByType("GPU"));
            comboBox3.Items.AddRange(_list.GetNamesByType("RAM"));
            comboBox4.Items.AddRange(_list.GetNamesByType("Mainboard"));
        }

        private void reward1_Click(object sender, EventArgs e)
        {

            try
            {
                RewardSingleton reward = new RewardSingleton();
                MessageBox.Show("Wygrałeś kupon rabatowy na nic: R49238HJFSD",
                    "Gratulacje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Odebrałeś już tę nagrodę", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string selectedValue = cmb.SelectedItem.ToString();
            var component = _list.GetComponentByName(selectedValue);

            if (component.Efficency + (int)performanceInd.CurrentPerformance > 100)
            {
                MessageBox.Show("Komponenty się powtarzają! Usuń elementy i dodaj na nowo!",
                                    "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add(selectedValue);
                assembler.AddAsset(component);
                performanceBar.Value = (int)performanceInd.CurrentPerformance;
                priceLabel.Text = priceInd.TotalPrice.ToString() + " zł";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;
            if (selectedItem != null)
            {
                listBox1.Items.Remove(selectedItem);
                assembler.RemoveAsset(_list.GetComponentByName(selectedItem.ToString()));
                performanceBar.Value = (int)performanceInd.CurrentPerformance;
                priceLabel.Text = priceInd.TotalPrice.ToString() + " zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlConverter xmlConverter = new XmlConverter(assembler.displayedComps);
            var xml = xmlConverter.GetXML();
            Form form = new Form2(xml.ToString());
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlConverter xmlConverter = new XmlConverter(assembler.displayedComps);
            var adapter = new XmlToJsonAdapter(xmlConverter);

            var json = adapter.ConvertXmlToJson();
            Form form = new Form2(json);
            form.ShowDialog();

        }
    }
}
