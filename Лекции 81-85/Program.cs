namespace Lessons
{
    //1. Описать класс "параллелепипед", класс должен иметь базовый конструктор и конструктор с параметрами
    //Должны быть реализованы методы получения\установки значений x y z
    //Должны быть реализованы методы по вычислению периметров граней, объема фигуры, площади граней и общей площадью
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введiть координати");
            double x = GetTheNumber();
            double y = GetTheNumber();
            double z = GetTheNumber();


            Parallelepiped parallelepiped1 = new Parallelepiped("Паралелепiпедом називається багатогранник, у якого 6 граней, 8 вершин i 12 ребер.", x, y, z);
            while (true)
            {
                Console.WriteLine("Оберiть, будь ласка функцiонал, де \n1 - Iнформацiя про паралелепiпед\n2 - Вирахувати периметри граней\n3 - Об'єм паралелепiпеда\n4 - Площа бiчної поверхнi\n5 - Площа повної поверхнi\n6 - Значення X\n7 - Значення Y\n8 - Значення Z\n9 - Змiнити X\n10 - Змiнити Y\n11 - Змiнити Z\n0 - Вихiд");
                double yourChoice = GetTheNumber();
                Console.Clear();
                switch (yourChoice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(parallelepiped1.ReturnThisDefinition());
                        break;
                    case 2:
                        Console.WriteLine(parallelepiped1.GetTheEdgePerimeters());
                        break;
                    case 3:
                        Console.WriteLine(parallelepiped1.GetTheVolumeOfTheParallelepiped());
                        break;
                    case 4:
                        Console.WriteLine(parallelepiped1.GetLateralSurfaceArea());
                        break;
                    case 5:
                        Console.WriteLine(parallelepiped1.GetTotalSurfaceArea());
                        break;
                    case 6:
                        Console.WriteLine(parallelepiped1.GetAnX());
                        break;
                    case 7:
                        Console.WriteLine(parallelepiped1.GetAnY());
                        break;
                    case 8:
                        Console.WriteLine(parallelepiped1.GetAnZ());
                        break;
                    case 9:
                        Console.WriteLine("Введiть координати X");
                        double changeX = GetTheNumber();
                        parallelepiped1.SetAnX(changeX);
                        break;
                    case 10:
                        Console.WriteLine("Введiть координати Y");
                        double changeY = GetTheNumber();
                        parallelepiped1.SetAnY(changeY);
                        break;
                    case 11:
                        Console.WriteLine("Введiть координати Z");
                        double changeZ = GetTheNumber();
                        parallelepiped1.SetAnZ(changeZ);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
            }
        }
        static private double GetTheNumber()
        {
            string theMeasurementString = Console.ReadLine();
            double.TryParse(theMeasurementString, out double theMeasurementInt);
            return theMeasurementInt;
        }
    }
    class Parallelepiped
    {
        private string definition;
        private double theFirstMeasurement;
        private double theSecondMeasurement;
        private double theThirdMeasurement;

        public Parallelepiped(string definition, double theFirstMeasurement, double theSecondMeasurement, double theThirdMeasurement)
        {
            this.definition = definition;
            this.theFirstMeasurement = theFirstMeasurement;
            this.theSecondMeasurement = theSecondMeasurement;
            this.theThirdMeasurement = theThirdMeasurement;
        }
        public Parallelepiped()
        {

        }

        public string ReturnThisDefinition()
        {
            return definition;
        }
        public double GetTheEdgePerimeters()
        {
            return theFirstMeasurement + theSecondMeasurement + theThirdMeasurement;
        }
        public double GetTheVolumeOfTheParallelepiped()
        {
            return theFirstMeasurement * theSecondMeasurement * theThirdMeasurement;
        }
        public double GetLateralSurfaceArea()
        {
            return ((theFirstMeasurement * theSecondMeasurement) * 2) * theThirdMeasurement;
        }
        public double GetTotalSurfaceArea()
        {
            return GetLateralSurfaceArea() + 2 * (theFirstMeasurement * theSecondMeasurement);
        }
        public double GetAnX()
        {
            return theFirstMeasurement;
        }
        public double GetAnY()
        {
            return theSecondMeasurement;
        }
        public double GetAnZ()
        {
            return theThirdMeasurement;
        }
        public void SetAnX(double changeX)
        {
            theFirstMeasurement = changeX;
        }
        public void SetAnY(double changeY)
        {
            theSecondMeasurement = changeY;
        }
        public void SetAnZ(double changeZ)
        {
            theThirdMeasurement = changeZ;
        }
    }
}