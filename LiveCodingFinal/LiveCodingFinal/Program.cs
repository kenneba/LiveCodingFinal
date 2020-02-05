using System;

namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Halloween is coming, and you need to figure out how much candy to buy.Luckily you have tracked the weather, 
            ////temperature, and number of tricker treaters from years past.
            ////From your research you have tracked 4 different types of weather: 
            ////"Clear", "Cloudy", "Raining", "Full Moon"From your research you have tracked 4 differnt types of temperature 40s, 50s, 60s, 70s
            ////    You get 10% more trick or treaters if the weather is clear
            ////        You get 0% more trick or treaters if the weather is cloudy
            ////        You get 25% less trick or treaters if the weather is rainy
            ////        You get 25% more trick or treaters if the weather is Full Moon
            ////        You get more trick or treaters the warmer the weather
            ////    You get 5% less trick or treaters if it's in the 40s
            //You get 0% more trick or treaters if it's in the 50s
            //You get 5% more trick or treaters if it's in the 60s\
            //You get 20% more trick or treaters if its' in the 70s
            //        On average you get 250 trick or treaters, and you want to give each kid 3 pieces of candy.
            //    How much candy do you need to buy if it's clear, and in the 50s?825
            //        How much candy do you need to buy if it's a full moon, and in the 40s?900
            //        How much candy do you need to buy if it's raining, and in the 70s?712.5"""


            //Get type
            Console.WriteLine("What is the type of weather?");
            string weathertype = Console.ReadLine();

            Console.WriteLine("What is the temp");
            string temps = Console.ReadLine();

            double numoftrickers = 250;

            if (weathertype == "Clear")
            {
                numoftrickers += (numoftrickers * .10);
                if (temps == "40")
                {
                    numoftrickers -= (numoftrickers * .05);
                }
                if (temps == "50")
                {
                    numoftrickers -= (numoftrickers * .0);

                }
                if (temps == "60")
                {
                    numoftrickers -= (numoftrickers * .05);
                }
                if (temps == "70")
                {
                    numoftrickers -= (numoftrickers * .20);
                }


                else if (weathertype == "Cloudy")
                {
                    numoftrickers += (numoftrickers * .0);
                    if (temps == "40")
                    {
                        numoftrickers -= (numoftrickers * .05);
                    }
                    if (temps == "50")
                    {
                        numoftrickers -= (numoftrickers * .0);

                    }
                    if (temps == "60")
                    {
                        numoftrickers -= (numoftrickers * .05);
                    }
                    if (temps == "70")
                    {
                        numoftrickers -= (numoftrickers * .20);
                    }

                    else if (weathertype == "Rainy")
                    {
                        numoftrickers -= (numoftrickers * .25);
                        if (temps == "40")
                        {
                            numoftrickers -= (numoftrickers * .05);
                        }
                        if (temps == "50")
                        {
                            numoftrickers -= (numoftrickers * .0);

                        }
                        if (temps == "60")
                        {
                            numoftrickers -= (numoftrickers * .05);
                        }
                        if (temps == "70")
                        {
                            numoftrickers -= (numoftrickers * .20);
                        }
                    }
                    else if (weathertype == "Full Moon")
                    {
                        numoftrickers += (numoftrickers * .25);
                        if (temps == "40")
                        {
                            numoftrickers -= (numoftrickers * .05);
                        }
                        if (temps == "50")
                        {
                            numoftrickers -= (numoftrickers * .0);

                        }
                        if (temps == "60")
                        {
                            numoftrickers -= (numoftrickers * .05);
                        }
                        if (temps == "70")
                        {
                            numoftrickers -= (numoftrickers * .20);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No one gets any candy!");
                    }



                }

                
            }
            Console.WriteLine("I need" + numoftrickers * 3 + "pieces of candy.");
            Console.ReadLine();
        }
    }
}
