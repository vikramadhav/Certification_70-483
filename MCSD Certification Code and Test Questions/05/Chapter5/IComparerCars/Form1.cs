using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparerCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Cars.
        private Car[] Cars;

        private void Form1_Load(object sender, EventArgs e)
        {
            sortByComboBox.SelectedIndex = 0;

            // Make some data.
            // Source: http://www.thesupercars.org/fastest-cars/fastest-cars-in-the-world-top-10-list.
            Cars = new Car[]
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

            // Display the cars sorted appropriately.
            DisplayCars();
        }

        // Display the cars in the ListView control.
        private void DisplayCars()
        {
            if (Cars == null) return;

            // Make the appropriate comparer.
            CarComparer comparer = new CarComparer();
            if (sortByComboBox.Text == "Name")
                comparer.SortBy = CarComparer.CompareField.Name;
            else if (sortByComboBox.Text == "Max MPH")
                comparer.SortBy = CarComparer.CompareField.MaxMph;
            else if (sortByComboBox.Text == "Horsepower")
                comparer.SortBy = CarComparer.CompareField.Horsepower;
            else
                comparer.SortBy = CarComparer.CompareField.Price;

            // Sort.
            Array.Sort(Cars, comparer);

            // If we're not sorting by name, reverse the array.
            if (sortByComboBox.Text != "Name") Array.Reverse(Cars);

            carListView.Items.Clear();
            foreach (Car car in Cars)
            {
                ListViewItem item = carListView.Items.Add(car.Name);
                item.SubItems.Add(car.MaxMph.ToString());
                item.SubItems.Add(car.Horsepower.ToString());
                item.SubItems.Add(car.Price.ToString("C"));
            }
            foreach (ColumnHeader header in carListView.Columns)
            {
                header.Width = -2;
            }
        }

        // Redisplay the cars.
        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCars();
        }
    }
}
