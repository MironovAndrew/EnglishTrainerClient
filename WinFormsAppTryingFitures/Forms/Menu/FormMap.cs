using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace WinFormsAppTryingFitures
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();

            List<string> brancheNamesList = new List<string>();
            List<string> phoneNumbersList = new List<string>();
            List<decimal> latitudeList = new List<decimal>();
            List<decimal> longitudeList = new List<decimal>();




            string connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM branches", connection);


            SqlDataReader dataReader = command.ExecuteReader();



            while (dataReader.Read())
            {
                brancheNamesList.Add(Convert.ToString(dataReader["name"]));
                phoneNumbersList.Add(Convert.ToString(dataReader["phone_number"]));
                latitudeList.Add(Convert.ToDecimal(dataReader["latitude"]));
                longitudeList.Add(Convert.ToDecimal(dataReader["longitude"]));
            }







            //убрать крестик
            gMapControl.ShowCenter = false;


            gMapControl.CanDragMap = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MapProvider = GMapProviders.GoogleMap;


            gMapControl.PolygonsEnabled = true;



            gMapControl.ShowTileGridLines = false;






            gMapControl.Position = new PointLatLng(Convert.ToDouble(latitudeList[0]), Convert.ToDouble(longitudeList[0]));


            // как приближает (просто в центр карты или по положению мыши)
            gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;





            gMapControl.MinZoom = 10;
            gMapControl.MaxZoom = 18;
            gMapControl.Zoom = 15;










            for (int i = 0; i < brancheNamesList.Count; i++)
            {


                //Вид маркера
                PointLatLng point = new PointLatLng(Convert.ToDouble(latitudeList[i]), Convert.ToDouble(longitudeList[i]));
                //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);


                marker.ToolTip = new GMapRoundedToolTip(marker);



                marker.ToolTipText = "\n" + brancheNamesList[i] + "\n" + phoneNumbersList[i] + "\n";
                



                //добавляем маркеры

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);

                gMapControl.Overlays.Add(markers);
            }









        }
    }
}
