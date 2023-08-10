using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            DateTime.Today.ToString();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int idCounter = 1;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int rowIndex =
               dataGridView1.Rows.Count - 1;

            
           
            string Nombre = textBoxnom.Text;
            string BienoActivo = textBoxbien.Text;
            string Riesgo = textBoxries.Text;
            string Daño = textBoxdaño.Text;
            dataGridView1.Rows.Add(idCounter,Nombre, BienoActivo, Riesgo, Daño);

            idCounter++;

            
            textBoxnom.Clear();
            textBoxbien.Clear();
            textBoxries.Clear();
            textBoxdaño.Clear();


        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)



                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
      

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_evalucion_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }

     

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            string columna0 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value?.ToString();
            string columna1 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value?.ToString();
            string columna2 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value?.ToString();
            string columna3 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value?.ToString();
            string columna4 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value?.ToString();
            string columna5 = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value?.ToString();

        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i ++) 
            {
               
                    {
                        UpdateTab2(i);
                        UpdateTab3(i);
                        UpdateTab4(i);
                    }

                }

        }
        private void UpdateTab2(int i)
        {
            var dtgv_valoresRows = dtgv_valores.Rows[i];
            var dataGridView1Rows = dataGridView1.Rows[i];


            if (dtgv_valores.Rows.Count < dataGridView1.Rows.Count)
            {
                dtgv_valores.Rows.Add();
            }
            dtgv_valoresRows.Cells[0].Value = dataGridView1Rows.Cells[2].Value;
            dtgv_valoresRows.Cells[1].Value = dataGridView1Rows.Cells[3].Value;
            dtgv_valoresRows.Cells[2].Value = dataGridView1Rows.Cells[4].Value;
        }
            private void UpdateTab3(int i)
        {
            var dtgv_evaluacionRows = dtgv_evaluacion.Rows[i];
            var dtgv_valoresRows = dtgv_valores.Rows[i];

            int F = Convert.ToInt32(dtgv_valoresRows.Cells[4].Value);
            int S = Convert.ToInt32(dtgv_valoresRows.Cells[3].Value);
            int P = Convert.ToInt32(dtgv_valoresRows.Cells[5].Value);
            int E = Convert.ToInt32(dtgv_valoresRows.Cells[8].Value);
            int A = Convert.ToInt32(dtgv_valoresRows.Cells[6].Value);
            int V = Convert.ToInt32(dtgv_valoresRows.Cells[7].Value);

            int I = F * S;
            int D = P * E;
            int Pb = A * V;
            int C = I + D;
            int ER = Pb * C;

            if (dtgv_evaluacion.Rows.Count < dtgv_valores.Rows.Count)
            {
                dtgv_evaluacion.Rows.Add();
            }

            dtgv_evaluacionRows.Cells[0].Value = dtgv_valoresRows.Cells[0].Value;
            dtgv_evaluacionRows.Cells[1].Value = dtgv_valoresRows.Cells[1].Value;
            dtgv_evaluacionRows.Cells[2].Value = dtgv_valoresRows.Cells[2].Value;

            dtgv_evaluacionRows.Cells[3].Value = C;
            dtgv_evaluacionRows.Cells[4].Value = Pb;
            dtgv_evaluacionRows.Cells[5].Value = ER;
        }

        private void dtgv_valores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_valores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellvalores = dtgv_valores.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.ColumnIndex >= 3)
            {
                if (int.TryParse(cellvalores.Value?.ToString(), out int numericValue) && numericValue >= 1 && numericValue <= 5)
                {
                    switch (numericValue)
                    {
                        case 1:
                            cellvalores.Style.BackColor = Color.Lime;
                            break;
                        case 2:
                            cellvalores.Style.BackColor = Color.LimeGreen;
                            break;
                        case 3:
                            cellvalores.Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            cellvalores.Style.BackColor = Color.Orange;
                            break;
                        case 5:
                            cellvalores.Style.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }


            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_evaluacion_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            {
               
            }
          
        }

        private void dtgv_valores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex >= 3 && e.ColumnIndex <= 8 && !string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                try
                {
                    int numericValue = int.Parse(e.FormattedValue.ToString());
                    if (numericValue < 1 || numericValue > 5)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Inserte valor entre 1 y 5.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    MessageBox.Show("Inserte valor numérico.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateTab4(int i)
        {

            if (dtgvClassification.Rows.Count < dtgv_evaluacion.Rows.Count)
            {
                dtgvClassification.Rows.Add();
            }
            var dtgvClassRows = dtgvClassification.Rows[i];
            var dtgvEvaluationRows = dtgv_evaluacion.Rows[i];

            dtgvClassRows.Cells[0].Value = dtgvEvaluationRows.Cells[0].Value;
            dtgvClassRows.Cells[1].Value = dtgvEvaluationRows.Cells[1].Value;
            dtgvClassRows.Cells[2].Value = dtgvEvaluationRows.Cells[5].Value;

            DataGridViewCell ERValue = dtgvClassification.Rows[i].Cells[2];
            DataGridViewRow ClassRow = dtgvClassification.Rows[i];

            if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)
            {
                ClassRow.Cells[3].Value = "Muy Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.Lime;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
            {
                ClassRow.Cells[3].Value = "Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.LimeGreen;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
            {
                ClassRow.Cells[3].Value = "Normal";
                ClassRow.Cells[3].Style.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
            {
                ClassRow.Cells[3].Value = "Grande";
                ClassRow.Cells[3].Style.BackColor = Color.Orange;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
            {
                ClassRow.Cells[3].Value = "Elevado";
                ClassRow.Cells[3].Style.BackColor = Color.Red;
            }

            dtgvClassification.Sort(dtgvClassification.Columns[2], ListSortDirection.Descending);
        }
        public class RiskAnalysis
        {

            public string Analista { get; set; }
            public string Activo { get; set; }
            public string Riesgo { get; set; }
            public string Dano { get; set; }
            public string Clasificacion { get; set; }
            //public int ID { get; set; }
            public int S { get; set; }
            public int F { get; set; }
            public int P { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            public int E { get; set; }
            public int CR { get; set; }
            public int Pb { get; set; }
            public int ER { get; set; }
        }

        private void SaveData(int i)
        {
            using (var db = new LiteDatabase(@"C:\Users\HP\Desktop\Test.db"))
            {
                var col = db.GetCollection<RiskAnalysis>(textBoxbien.Text + "_" + txtID.Text);
                DataGridViewRow Evaluation = dtgv_evaluacion.Rows[i];
                DataGridViewRow Values = dtgv_valores.Rows[i];
                var DataSave = new RiskAnalysis
                {
                    //ID = 1,
                    Analista  = textBoxnom.Text,
                    Activo = textBoxbien.Text,
                    Riesgo = Evaluation.Cells[1].Value.ToString(),
                    Dano = Evaluation.Cells[2].Value.ToString(),

                    S = Convert.ToInt16(Values.Cells[3].Value),
                    F = Convert.ToInt16(Values.Cells[4].Value),
                    P = Convert.ToInt16(Values.Cells[5].Value),
                    A = Convert.ToInt16(Values.Cells[6].Value),
                    V = Convert.ToInt16(Values.Cells[7].Value),
                    E = Convert.ToInt16(Values.Cells[8].Value),
                    CR = Convert.ToInt32(Evaluation.Cells[3].Value),
                    Pb = Convert.ToInt32(Evaluation.Cells[4].Value),
                    ER = Convert.ToInt32(Evaluation.Cells[5].Value),

                    Clasificacion = Classify(i)
                };
                col.Insert(DataSave);
            }
        }
        private string Classify(int i)
        {
            DataGridViewCell ERValue = dtgvClassification.Rows[i].Cells[2];

            if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)
            {
                return "Muy Pequeño";
            }
            else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
            {
                return "Pequeño";
            }
            else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
            {
                return "Normal";
            }
            else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
            {
                return "Grande";
            }
            else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
            {
                return "Elevado";
            }
            else return "";
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                UpdateTab3(i);
                UpdateTab4(i);
                SaveData(i);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

        }
    }
}




!//for (int i = 0; i < dtgv1.Rows.Count; i++)
            {

    {
        UpdateTab2(i);
        UpdateTab3(i);
        UpdateTab4(i);
    }

}

        }
        private void UpdateTab2(int i)
{
    var dtgvValoresRows = dtgvValores.Rows[i];
    var dtgv1Rows = dtgv1.Rows[i];


    if (dtgvValores.Rows.Count < dtgv1.Rows.Count)
    {
        dtgvValores.Rows.Add();
    }
    dtgvValoresRows.Cells[0].Value = dtgv1Rows.Cells[2].Value;
    dtgvValoresRows.Cells[1].Value = dtgv1Rows.Cells[3].Value;
    dtgvValoresRows.Cells[2].Value = dtgv1Rows.Cells[4].Value;
}
private void UpdateTab3(int i)
{
    var dtgv_evaluacionRows = dtgvevaluacion.Rows[i];
    var dtgv_valoresRows = dtgvValores.Rows[i];

    int F = Convert.ToInt32(dtgv_valoresRows.Cells[4].Value);
    int S = Convert.ToInt32(dtgv_valoresRows.Cells[3].Value);
    int P = Convert.ToInt32(dtgv_valoresRows.Cells[5].Value);
    int E = Convert.ToInt32(dtgv_valoresRows.Cells[8].Value);
    int A = Convert.ToInt32(dtgv_valoresRows.Cells[6].Value);
    int V = Convert.ToInt32(dtgv_valoresRows.Cells[7].Value);

    int I = F * S;
    int D = P * E;
    int Pb = A * V;
    int C = I + D;
    int ER = Pb * C;

    if (dtgvevaluacion.Rows.Count < dtgvValores.Rows.Count)
    {
        dtgvevaluacion.Rows.Add();
    }

    dtgv_evaluacionRows.Cells[0].Value = dtgv_valoresRows.Cells[0].Value;
    dtgv_evaluacionRows.Cells[1].Value = dtgv_valoresRows.Cells[1].Value;
    dtgv_evaluacionRows.Cells[2].Value = dtgv_valoresRows.Cells[2].Value;

    dtgv_evaluacionRows.Cells[3].Value = C;
    dtgv_evaluacionRows.Cells[4].Value = Pb;
    dtgv_evaluacionRows.Cells[5].Value = ER;
}
    }
    private void UpdateTab4(int i)
{

    if (dtgvClassification.Rows.Count < dtgv_evaluacion.Rows.Count)
    {
        dtgvClassification.Rows.Add();
    }
    var dtgvClassRows = dtgvClassification.Rows[i];
    var dtgvEvaluationRows = dtgv_evaluacion.Rows[i];

    dtgvClassRows.Cells[0].Value = dtgvEvaluationRows.Cells[0].Value;
    dtgvClassRows.Cells[1].Value = dtgvEvaluationRows.Cells[1].Value;
    dtgvClassRows.Cells[2].Value = dtgvEvaluationRows.Cells[5].Value;

    DataGridViewCell ERValue = dtgvClassification.Rows[i].Cells[2];
    DataGridViewRow ClassRow = dtgvClassification.Rows[i];

    if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)
    {
        ClassRow.Cells[3].Value = "Muy Pequeño";
        ClassRow.Cells[3].Style.BackColor = Color.Lime;
    }
    else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
    {
        ClassRow.Cells[3].Value = "Pequeño";
        ClassRow.Cells[3].Style.BackColor = Color.LimeGreen;
    }
    else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
    {
        ClassRow.Cells[3].Value = "Normal";
        ClassRow.Cells[3].Style.BackColor = Color.Yellow;
    }
    else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
    {
        ClassRow.Cells[3].Value = "Grande";
        ClassRow.Cells[3].Style.BackColor = Color.Orange;
    }
    else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
    {
        ClassRow.Cells[3].Value = "Elevado";
        ClassRow.Cells[3].Style.BackColor = Color.Red;
    }

    dtgvClassification.Sort(dtgvClassification.Columns[2], ListSortDirection.Descending);
}
public class RiskAnalysis
{

    public string Analista { get; set; }
    public string Activo { get; set; }
    public string Riesgo { get; set; }
    public string Dano { get; set; }
    public string Clasificacion { get; set; }
    //public int ID { get; set; }
    public int S { get; set; }
    public int F { get; set; }
    public int P { get; set; }
    public int A { get; set; }
    public int V { get; set; }
    public int E { get; set; }
    public int CR { get; set; }
    public int Pb { get; set; }
    public int ER { get; set; }

