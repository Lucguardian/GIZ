using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Cria o layer
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");

            //Designa a fonte de dados
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile("C:/Geoprocessamento/GIZ-shp/states_ugl.shp", true);

            //Cria o estilo para Terra
            SharpMap.Styles.VectorStyle landStyle = new SharpMap.Styles.VectorStyle();
            landStyle.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(232, 232, 232));

            //Cria o estilo para Água
            SharpMap.Styles.VectorStyle waterStyle = new SharpMap.Styles.VectorStyle();
            waterStyle.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(198, 198, 255));

            //Cria os itens do tema
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, SharpMap.Styles.IStyle>();
            styles.Add("land", landStyle);
            styles.Add("water", waterStyle);

            //Designa o tema
            vlay.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("class", styles, landStyle);

            //Adiciona o layer ao mapa
            mapBox1.Map.Layers.Add(vlay);
            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
