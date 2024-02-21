namespace AS2324._3G.Guardabascio.Riccardo.Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Riccardo Guardabascio 3G 08/02/24 Rubrica");
            int scelta = 0;
            string[] nomi = new string[100];
            string[] cognomi = new string[100];
            string[] email = new string[100];
            string[] nickname = new string[100];
            int[] simpatia = new int[100];
            int[] annonascita = new int[100];
            int nContatti = 0;
            do
            {
                Console.WriteLine("Inserire una scelta:");
                Console.WriteLine("1)Crea nuovo contatto");
                Console.WriteLine("2)Elenco contatti");
                Console.WriteLine("3)Ricerca di un cotatto tramite nickname");
                Console.WriteLine("9)Fine");
                Console.WriteLine("\n");


                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Creazione nuovo contatto");
                        do
                        {
                            Console.WriteLine($"Inserire il nome del {nContatti + 1}° contatto (Questo campo è obbligatorio)");
                            nomi[nContatti] = Convert.ToString(Console.ReadLine());
                        } while (nomi[nContatti] == "");

                        do
                        {
                            Console.WriteLine($"Inserire il cognome del {nContatti + 1}° contatto (Questo campo è obbligatorio)");
                            cognomi[nContatti] = Convert.ToString(Console.ReadLine());
                        } while (cognomi[nContatti] == "");

                        Console.WriteLine($"Inserire l'email del {nContatti + 1}° contatto");
                        email[nContatti] = Convert.ToString(Console.ReadLine());

                        Console.WriteLine($"Inserire la simpatia (Compresa tra 1 e 5) del {nContatti + 1}° contatto");
                        simpatia[nContatti] = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.WriteLine($"Inserire il nickname del {nContatti + 1}° contatto");
                            nickname[nContatti] = Convert.ToString(Console.ReadLine());
                        } while (nickname[nContatti] == "");

                        Console.WriteLine($"Inserire l'anno di nascita del {nContatti + 1}° contatto");
                        annonascita[nContatti] = Convert.ToInt32(Console.ReadLine());

                        nContatti++;
                        break;

                    case 2:
                        Console.WriteLine("Elenco contatti");
                        Console.WriteLine("\n");
                        for (int i = 0; i < nContatti; i++)
                        {
                            Console.WriteLine($"Contatto numero {i + 1}: Nome: {nomi[i]}, Cognome: {cognomi[i]}, Email: {email[i]}, Simpatia: {simpatia[i]}, Nickname: {nickname[i]}, Anno di nascita: {annonascita[i]}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ricerca di un nominativo in base al nickname");
                        Console.WriteLine("Inserire il nickname da cercare");
                        string nick=Convert.ToString(Console.ReadLine());
                        for (int i=0; i<nContatti;i++)
                        {
                            if (nick == nickname[i])
                            {
                                Console.WriteLine($"Il nickname inserito corrisponde al contatto numero {i + 1}");
                                Console.WriteLine("\n");
                                Console.WriteLine($"Nome: {nomi[i]}, Cognome: {cognomi[i]}, Email: {email[i]}, Simpatia: {simpatia[i]}, Nickname: {nickname[i]}, Anno di nascita: {annonascita[i]}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ricerca di un nominativo case insensitive");
                        Console.WriteLine("Inserire un nome da cercare");
                        string nomeInserito=Convert.ToString(Console.ReadLine());
                        for (int i = 0; i < nContatti; i++)
                        {
                            if (nomeInserito.ToUpper() == nomi[i].ToUpper())
                            {
                                Console.WriteLine($"Il nome {nomeInserito} corrisponde al contatto numero {i + 1}");
                                Console.WriteLine("\n");
                            }
                        }
                    break;
                    case 5:
                        Console.WriteLine("Ricerca di tutti i cognomi in base alle iniziali");
                        Console.WriteLine("Inserire l'iniziale di un cognome da cercare");
                        string cognomeInserito = Convert.ToString(Console.ReadLine());
                        for (int i = 0; i < nContatti; i++)
                        {
                            if (cognomi[i].ToUpper().StartsWith(cognomeInserito.ToUpper())==true)
                            {
                                Console.WriteLine($"L'iniziale {cognomeInserito} corrisponde al cognome {cognomi[i]}");
                                Console.WriteLine("\n");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ricerca di tutti i cognomi che contengono la parte inserita");
                        Console.WriteLine("Inserire la parte di un cognome da cercare");
                        string parteCognome = Convert.ToString(Console.ReadLine());
                        for (int i = 0; i < nContatti; i++)
                        {
                            if (cognomi[i].ToUpper().Contains(parteCognome.ToUpper()) == true)
                            {
                                Console.WriteLine($"L'iniziale {parteCognome} corrisponde al cognome {cognomi[i]}");
                                Console.WriteLine("\n");
                            }
                        }
                        break;


                }
            } while (scelta != 0);

        }
    }
}