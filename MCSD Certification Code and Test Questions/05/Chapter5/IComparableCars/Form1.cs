using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparableCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some data.
            // Source: http://www.thesupercars.org/fastest-cars/fastest-cars-in-the-world-top-10-list.
            Car[] cars =
            {
                new Car() { Name="SSC Ultimate Aero", MaxMph=257, Horsepower=1183, Price=654400m},
                new Car() { Name="Bugatti Veyron", MaxMph=253, Horsepower=1001, Price=1700000m},
                new Car() { Name="Saleen S7 Twin-Turbo", MaxMph=248, Horsepower=750, Price=555000m},
                new Car() { Name="Koenigsegg CCX", MaxMph=245, Horsepower=806, Price=545568m},
                new Car() { Name="McLaren F1", MaxMph=240, Horsepower=637, Price=970000m},
                new Car() { Name="Ferrari Enzo", MaxMph=217, Horsepower=660, Price=670000m},
                new Car() { Name="Jaguar XJ220", MaxMph=217, Horsepower=542, Price=650000m},
                new Car() { Name="Pagani Zonda F", MaxMph=215, Horsepower=650, Price=667321m},
                new Car() { Name="Lamborghini Murcielago LP640", MaxMph=211, Horsepower=640, Price=430000m},
                new Car() { Name="Porsche Carrera GT", MaxMph=205, Horsepower=612, Price=440000m},
            };

            // Display the cars unsorted.
            DisplayCars(cars, unsortedListView);

            // Sort the array of cars.
            Array.Sort(cars);

            // Display the cars sorted.
            DisplayCars(cars, sortedListView);
        }

        // Display the cars in the ListView control.
        private void DisplayCars(Car[] cars, ListView listView)
        {
            listView.Items.Clear();
            foreach (Car car in cars)
            {
                ListViewItem item = listView.Items.Add(car.Name);
                item.SubItems.Add(car.MaxMph.ToString());
                item.SubItems.Add(car.Horsepower.ToString());
                item.SubItems.Add(car.Price.ToString("C"));
            }
            foreach (ColumnHeader header in listView.Columns)
            {
                header.Width = -2;
            }
        }
    }
}
