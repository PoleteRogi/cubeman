using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMan
{
    public static class Actions
    {
        private static string[] jokes = new string[] {"Guess the number of programmers it takes to change a light bulb? Zero its a hardware problem","There are only 10 kinds of people in this world: those who know binary and those who don’t.","Real programmers count from 0.", "Why did the programmer quit his job? Because he didnt get arrays.", "A foo walks into a bar takes a look around and says Hello World","0 is false 1 is true right? 1",
        "Things arent always #000000 and #FFFFFF.","What is the most used language in programming? Profanity","!False its funny because its True","You had me at Hello World","2b||!2b","Yesterday I changed the name on my wifi to Hack if you can. Today I found it named Challenge Accepted","A programmer is a person who fixed a problem that you didnt know you had in a way you dont understand","How can you tell if a computer geek is an extrovert? They stare at your shoes when you talk instead of their own.","I would love to change the world but they wont give me the source code.","If at first you dont succedd call it version 1.0","Computers make very fast very accurate mistakes","I farted in the Apple store and everyone got mad at me. Not my fault they dont have Windows.","Knock Knock... Whos there? Art... Art Who? R2D2","Hilarious and amazingly true thing: if a pizza has a radius (z) and a depth (a) that pizzas volume can be defined Pi*z*z*a."};
        private static string[] spanishjokes = new string[] {"¿Adivina la cantidad de programadores que se necesitan para cambiar una bombilla? Cero es un problema de hardware", "Solo hay 10 tipos de personas en este mundo: los que saben binario y los que no", "Los programadores reales cuentan desde 0. "," ¿Por qué el programador renunció a su trabajo? Porque no obtuvo matrices. "," Un foo entra en un bar, echa un vistazo y dice Hola mundo "," 0 es falso 1 es verdadero ¿verdad? 1 " ,
        "Las cosas no siempre son # 000000 y #FFFFFF.", "¿Cuál es el lenguaje más utilizado en programación? Blasfemias", "! Falso es gracioso porque es Verdadero", "Me tuviste en Hello World", "2b ||! 2b "," Ayer cambié el nombre de mi wifi a Hack si puedes. Hoy lo encontré llamado Desafío aceptado "," Un programador es una persona que solucionó un problema que no sabías que tenías de una manera que no entiendes ", "¿Cómo puedes saber si un experto en informática es extrovertido? Miran fijamente tus zapatos cuando hablas en lugar de los suyos propios", "Me encantaría cambiar el mundo, pero no me darán el código fuente", "Si en primero no lo llamo versión 1.0 "," Las computadoras cometen errores muy rápidos y muy precisos "," Me tiré un pedo en la tienda de Apple y todos se enojaron conmigo. No es mi culpa que no tengan Windows "," Knock Knock ... ¿Quién está ahí? Arte ... ¿Arte Quién? R2D2 "," Cosa hilarante y asombrosamente cierta: si una pizza tiene un radio (z) y una profundidad (a) ese volumen de pizzas se puede definir Pi * z * z * a "};

        private static string[] phrases = new string[] {Program.username + ", if you like me, you can rate me if you want!",
        Program.username + ", if you need to calculate some maths, you can right click on me and press 'Calculator'",
        Program.username + ", wanna hear a joke? Just right click and press 'Tell joke'",
        Program.username + ", my creator is named 'Pol', such a beautiful name, isn't it?"};

        private static string[] spanishphrases = new string[] {Program.username + ", si te gusto, ¡puedes calificarme si quieres!",
         Program.username + ", si necesita calcular algunas matemáticas, puede hacer clic derecho sobre mí y presionar 'Calculator'",
         Program.username + ", ¿quieres escuchar una broma? Simplemente haz clic derecho y presiona 'Contar broma'",
         Program.username + ", mi creador se llama 'Pol', un nombre tan bonito, ¿no?"};
        public static string GetRandomJoke()
        {
            if(Program.langauge == "English")
            {
                int randomIndex = new Random().Next(0, jokes.Length);
                return jokes[randomIndex];
            }
            else
            {
                int randomIndex = new Random().Next(0, jokes.Length);
                return spanishjokes[randomIndex];
            }
        }

        public static char[] ToDialog(string message)
        {
            return message.ToCharArray();
        }

        public static string GetRandomPhrase()
        {
            if (Program.langauge == "English")
            {
                int randomIndex = new Random().Next(0, phrases.Length);
                return phrases[randomIndex];
            }
            else
            {
                int randomIndex = new Random().Next(0, spanishphrases.Length);
                return spanishphrases[randomIndex];
            }
        }
    }
}
