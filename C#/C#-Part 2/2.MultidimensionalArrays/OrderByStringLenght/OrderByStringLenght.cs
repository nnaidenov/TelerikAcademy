using System;

class OrderByStringLenght
{
    static void Main(string[] args)
    {
        string[] dinosaurs = {"Pachycephalosaurus", 
                            "Amargasaurus", 
                            "Tyrannosaurus", 
                            "Mamenchisaurus", 
                            "Deinonychus", 
                            "Edmontosaurus"};

        //Print Unsort Dinosaurs
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
        Console.WriteLine();

        //Sorting Dinosaurs With Selection sort
        for (int i = 0; i < dinosaurs.Length - 1; i++)
        {
            for (int j = i + 1; j < dinosaurs.Length; j++)
            {
                if (dinosaurs[i].Length > dinosaurs[j].Length)
                {
                    string swap = dinosaurs[i];
                    dinosaurs[i] = dinosaurs[j];
                    dinosaurs[j] = swap;
                }
            }
        }

        //Print Sort Dinosaurs
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }
}