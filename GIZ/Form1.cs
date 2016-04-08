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
            

            ////ex 4 - layer wms
            //SharpMap.Layers.WmsLayer wmsL = new SharpMap.Layers.WmsLayer("US Cities", "http://sampleserver1.arcgisonline.com/ArcGIS/services/Specialty/ESRI_StatesCitiesRivers_USA/MapServer/WMSServer");

            ////Força o uso de formato png, caso contrário não veríamos através dele.
            //wmsL.SetImageFormat("image/png");
            ////Força uso da versão 1.1.0
            //wmsL.Version = "1.1.0";
            ////Adiciona o layer chamado '2' no serviço (Cities)
            //wmsL.AddLayer("2");
            ////Define o SRID
            //wmsL.SRID = 4326;

            ////Adiciona o layer wmsL ao mapa
            //mapBox1.Map.Layers.Add(wmsL);

            //ex 5 - Tiled layer
            ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory ctfact = new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();
            vlay.CoordinateTransformation = ctfact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84, ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator);
            vlay.ReverseCoordinateTransformation = ctfact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator, ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84);

            mapBox1.Map.BackgroundLayer.Add(new SharpMap.Layers.TileAsyncLayer(new BruTile.Web.OsmTileSource(), "OSM"));

            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
