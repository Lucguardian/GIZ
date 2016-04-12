using GeoAPI.Geometries;
using SharpMap.Forms;
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
            //SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");

            ////Designa a fonte de dados
            //vlay.DataSource = new SharpMap.Data.Providers.ShapeFile("C:/Geoprocessamento/GIZ-shp/states_ugl.shp", true);

            ////Cria o estilo para Terra
            //SharpMap.Styles.VectorStyle landStyle = new SharpMap.Styles.VectorStyle();
            //landStyle.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(232, 232, 232));

            ////Cria o estilo para Água
            //SharpMap.Styles.VectorStyle waterStyle = new SharpMap.Styles.VectorStyle();
            //waterStyle.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(198, 198, 255));

            ////Cria os itens do tema
            //Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, SharpMap.Styles.IStyle>();
            //styles.Add("land", landStyle);
            //styles.Add("water", waterStyle);

            ////Designa o tema
            //vlay.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("class", styles, landStyle);

            ////Adiciona o layer ao mapa
            //mapBox1.Map.Layers.Add(vlay);
            

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
            //ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory ctfact = new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();
            //vlay.CoordinateTransformation = ctfact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84, ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator);
            //vlay.ReverseCoordinateTransformation = ctfact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator, ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84);

            //mapBox1.Map.BackgroundLayer.Add(new SharpMap.Layers.TileAsyncLayer(new BruTile.Web.OsmTileSource(), "OSM"));

            //mapBox1.Map.ZoomToExtents();
            //mapBox1.Refresh();
            //mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnAddVector_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "arquivos shape (*.shp)|*.shp|Todos os arquivos (*.*)|*.*"; //define o tipo de arquivo q pode ser selecionado
            openFileDialog1.FilterIndex = 1; //define qual das opções é padrão
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = openFileDialog1.FileName; //path inteiro do shape
                string y = openFileDialog1.SafeFileName; //apenas nome e extensão do arquivo
                SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer(y);
                vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(x, true);
                mapBox1.Map.Layers.Add(vlay);
                mapBox1.Map.ZoomToExtents();
                mapBox1.Refresh();
                mapBox1.ActiveTool = MapBox.Tools.Pan;
            }
        }

        private void tsbtnAddRaster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "arquivos jpg (*.jpg)|*.jpg|arquivos tiff (*.tif)|*.tif|todos os arquivos (*.*)|*.*"; //define o tipo de arquivo q pode ser selecionado
            openFileDialog1.FilterIndex = 2; //define qual das opções é padrão
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = openFileDialog1.FileName; //path inteiro do raster
                string y = openFileDialog1.SafeFileName; //apenas nome e extensão do arquivo
                SharpMap.Layers.GdiImageLayer rlay = new SharpMap.Layers.GdiImageLayer(x);
                mapBox1.Map.Layers.Add(rlay);
                mapBox1.Map.ZoomToExtents();
                mapBox1.Refresh();
                mapBox1.ActiveTool = MapBox.Tools.Pan;
            }
        }

        private void adicionarCamadaRasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "arquivos jpg (*.jpg)|*.jpg|arquivos tiff (*.tif)|*.tif|todos os arquivos (*.*)|*.*"; //define o tipo de arquivo q pode ser selecionado
            openFileDialog1.FilterIndex = 2; //define qual das opções é padrão
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = openFileDialog1.FileName; //path inteiro do raster
                string y = openFileDialog1.SafeFileName; //apenas nome e extensão do arquivo
                SharpMap.Layers.GdiImageLayer rlay = new SharpMap.Layers.GdiImageLayer(x);
                mapBox1.Map.Layers.Add(rlay);
                mapBox1.Map.ZoomToExtents();
                mapBox1.Refresh();
                mapBox1.ActiveTool = MapBox.Tools.Pan;
            }
        }

        private void adicionarNovaCamadaVetorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "arquivos shape (*.shp)|*.shp|Todos os arquivos (*.*)|*.*"; //define o tipo de arquivo q pode ser selecionado
            openFileDialog1.FilterIndex = 1; //define qual das opções é padrão
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = openFileDialog1.FileName; //path inteiro do shape
                string y = openFileDialog1.SafeFileName; //apenas nome e extensão do arquivo
                SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer(y);
                vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(x, true);
                mapBox1.Map.Layers.Add(vlay);
                mapBox1.Map.ZoomToExtents();
                mapBox1.Refresh();
                mapBox1.ActiveTool = MapBox.Tools.Pan;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja encerrar o programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    var pt = new CustomMapTool.PopupTool();
        //    MapBox _mapControl = null;
        //    pt.MapControl = _mapControl;
        //    pt.Enabled = true;
        //}
    }

    //public abstract class CustomMapTool
    //{
    //    private MapBox _mapControl;
    //    private bool _enabled;

    //    /// <summary>
    //    /// Event raised when the <see cref="MapControl"/> is about to change.
    //    /// </summary>
    //    public event CancelEventHandler MapControlChanging;

    //    /// <summary>
    //    /// Event invoker for the <see cref="MapControlChanging"/> event
    //    /// </summary>
    //    /// <remarks>Override this method to unwire <see cref="MapBox"/>s events. Don't forget to call <c>base.OnMapControlChanging(cea);</c> to invoke the event.</remarks>
    //    /// <param name="cea">The cancel event arguments</param>
    //    protected virtual void OnMapControlChanging(CancelEventArgs cea)
    //    {
    //        var h = MapControlChanging;
    //        if (h != null) h(this, cea);
    //    }

    //    /// <summary>
    //    /// Event raised when the <see cref="MapControl"/> has changed.
    //    /// </summary>
    //    public event EventHandler MapControlChanged;

    //    /// <summary>
    //    /// The event invoker 
    //    /// </summary>
    //    /// <remarks>Override this method to wire to <see cref="MapBox"/>s events. Don't forget to call <c>base.OnMapControlChanged(e);</c> to invoke the event.</remarks>
    //    /// <param name="e">The event arguments</param>
    //    protected virtual void OnMapControlChanged(EventArgs e)
    //    {
    //        var h = MapControlChanged;
    //        if (h != null) h(this, e);
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating the map control
    //    /// </summary>
    //    public SharpMap.Forms.MapBox MapControl
    //    {
    //        get { return _mapControl; }
    //        set
    //        {
    //            if (value == _mapControl)
    //                return;

    //            var cea = new CancelEventArgs(false);
    //            OnMapControlChanging(cea);
    //            if (cea.Cancel) return;
    //            _mapControl = value;
    //            OnMapControlChanged(EventArgs.Empty);
    //        }
    //    }

    //    /// <summary>
    //    /// Event raised when <see cref="Enabled"/> changed.
    //    /// </summary>
    //    public event EventHandler EnabledChanged;

    //    /// <summary>
    //    /// Event invoker for the <see cref="EnabledChanged"/> event.
    //    /// </summary>
    //    /// <param name="e"></param>
    //    protected virtual void OnEnabledChanged(EventArgs e)
    //    {
    //        var h = EnabledChanged;
    //        if (h != null) h(this, e);
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating if the tool is enabled or not
    //    /// </summary>
    //    public bool Enabled
    //    {
    //        get { return _mapControl != null && _enabled; }
    //        set
    //        {
    //            if (value == _enabled)
    //                return;
    //            _enabled = value;
    //            OnEnabledChanged(EventArgs.Empty);
    //        }
    //    }

    //    public class PopupTool : CustomMapTool
    //    {
    //        protected override void OnMapControlChanging(CancelEventArgs cea)
    //        {
    //            base.OnMapControlChanging(cea);
    //            if (cea.Cancel) return;

    //            if (MapControl == null) return;
    //            MapControl.MouseDown -= HandleMouseDown;
    //        }

    //        protected override void OnMapControlChanged(EventArgs e)
    //        {
    //            base.OnMapControlChanged(e);
    //            if (MapControl == null) return;
    //            MapControl.MouseDown += HandleMouseDown;
    //        }

    //        private void HandleMouseDown(Coordinate worldpos, MouseEventArgs imagepos)
    //        {
    //            if (!Enabled)
    //                return;

    //            MessageBox.Show(string.Format("You clicked at {0}!", worldpos));
    //            Enabled = false;
    //        }
    //    }
    //}
}
