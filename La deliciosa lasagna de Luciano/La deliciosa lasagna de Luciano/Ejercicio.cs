namespace La_deliciosa_lasagna_de_Luciano
{
    /*
        Consigna: 
            ¡La novia de Lucian está de camino a casa y él no ha preparado la cena de aniversario!

            En este ejercicio, escribirás código para ayudar a Lucian a cocinar una exquisita lasaña de su libro de cocina favorito.

            Tienes cuatro tareas, todas ellas relacionadas con el tiempo empleado en cocinar la lasaña.

            Tarea 1: Definir el tiempo esperado del horno en minutos.
                Define el método Lasagna.ExpectedMinutesInOven() que no toma ningún parámetro y devuelve cuántos minutos debe estar la lasaña en el horno. Según el libro de cocina, el tiempo esperado de horno en minutos es de 40.

            Tarea 2: Calcular el tiempo restante del horno en minutos.
                Defina el método Lasagna.RemainingMinutesInOven() que toma como parámetro los minutos reales que la lasaña ha estado en el horno y devuelve cuántos minutos aún le quedan a la lasaña en el horno, según el tiempo de horno esperado en minutos de la tarea anterior.
    
            Tarea 3: Calcular el tiempo de preparación en minutos.
                Defina el método Lasagna.PreparationTimeInMinutes() que toma la cantidad de capas que agregó a la lasaña como parámetro y devuelve cuántos minutos pasó preparando la lasaña, asumiendo que cada capa le toma 2 minutos para prepararse.
     */

    public class Lasagna
    {

        // Tarea 1: Defino el tiempo esperado del horno en minutos.
        public int ExpectedMinutesInOven()
        {
            return 40; // Según el libro de cocina, el tiempo esperado de horno en minutos es de 40.
        }

        // Tarea 2: Calcula el tiempo restante del horno en minutos.
        public int RemainingMinutesInOven(int actualMinutesInOven)
        {
            int expectedMinutes = ExpectedMinutesInOven();
            return expectedMinutes - actualMinutesInOven; // Calcula cuántos minutos quedan.
        }

        // Tarea 3: Calcula el tiempo de preparación en minutos.
        public int PreparationTimeInMinutes(int numberOfLayers)
        {
            return numberOfLayers * 2; // Cada capa le toma 2 minutos para prepararse.
        }

        static void Main(string[] args)
        {
            Lasagna lasagna = new Lasagna();

            // Tarea 1: Tiempo esperado en el horno
            int expectedOvenTime = lasagna.ExpectedMinutesInOven();
            Console.WriteLine("Tiempo esperado en el horno: " + expectedOvenTime + " minutos");

            // Tarea 2: Tiempo restante en el horno
            int actualMinutesInOven = 20; // Supongamos que la lasaña ha estado 20 minutos en el horno
            int remainingOvenTime = lasagna.RemainingMinutesInOven(actualMinutesInOven);
            Console.WriteLine("Tiempo restante en el horno: " + remainingOvenTime + " minutos");

            // Tarea 3: Tiempo de preparación
            int numberOfLayers = 5; // Supongamos que la lasaña tiene 5 capas
            int preparationTime = lasagna.PreparationTimeInMinutes(numberOfLayers);
            Console.WriteLine("Tiempo de preparación: " + preparationTime + " minutos");
        }
    }