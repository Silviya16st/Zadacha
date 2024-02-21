namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete spisak ot cvetove> Done za END!!! ");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                //mush in colorlist
                colorList.Add(input);
                input = Console.ReadLine();
            }

            //for (int i = 0; i < colorList.Count; i++)
            //{
            //    Console.WriteLine(colorList[i]);
            //}



            Console.WriteLine("Koi element da iztriesh 0-" + (colorList.Count-1));
            int index = int.Parse(Console.ReadLine());
            colorList.RemoveAt(index);
            colorList[0]="rozovo";



            foreach (string redKvadratche in colorList)
            {
                Console.WriteLine(redKvadratche);
            }

        }
    }
}
