namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asking for the student name
            Console.WriteLine("What is the student name?");

            //Getting the student name from user input
            string studentName = Console.ReadLine();

            //Asking for how many grades the student has
            Console.WriteLine("How many grades does this student have?");

            //Getting how many grades the student has from user input
            int gradesLength = int.Parse(Console.ReadLine());

            //Setting a new dynamic array with a kept length (from user input) to hold all the student grades
            float[] studentGrades = new float[gradesLength];


            //Looping through the array to ask the user to input each one of the student grades
            for (int i = 0; i < studentGrades.Length; i++)
            {
                Console.WriteLine("Type Grade number" + (i + 1) + ":");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }


            double average = CalculateAverage(studentGrades);

            Console.WriteLine(average);

        }


        static double CalculateAverage(float[] args)
        {

            double total = 0;
            //Looping through all grades adding each one to find the total


            for (int i = 0; i < args.Length; i++)

            {
                total += args[i];
            };


            double average = total / args.Length;


            return average;
        }

    }
}