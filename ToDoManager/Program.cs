using ToDoManager.Entities;
using ToDoManager.Services;

// création de l'objet qui s'occupera de gérer les tâches
ToDoService ts = new();

// création des tâches 
ToDo t1 = new ToDo("Faire du sport", "Faire les courses pour la soirée");
ToDo t2 = new ToDo("Faire la vaisselle", "Laver les casseroles");
ToDo t3 = new ToDo("Aller à la banque", "Ouvrir un compte épargne");

// ajouter à la liste en spécifiant à quelle date la tâche va être ajoutée = dans x jours par rapport à DateTime.Now
// si le nb de jours est négatif, la tâche sera pas affichée car on a exclu les dates passées grâce au Where de notre GetToDos()
ts.Add(t1, 2);
ts.Add(t2, 1);
ts.Add(t3, 42);

List<ToDo> l = ts.GetToDos();

foreach(ToDo t in l)
{
    Console.WriteLine($"{t.Name} - {t.Description} | {t.Date}");
}
