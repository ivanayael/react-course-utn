namespace clase4
{

    public class MovieController
    {


        // Factoria de metodos 
        // ObjetoAbstracto variable = new ClaseHerencia();
        public Movie createMovie(Genre genre)
        {

            switch (genre)
            {
                case Genre.Action:
                    return new Action();  // statament ---> 

                case Genre.Comedy:
                    return new Comedy();
                    
                case Genre.Horror:
                    return new Horror();

                default:
                    return null;
            }
        }
    }
}