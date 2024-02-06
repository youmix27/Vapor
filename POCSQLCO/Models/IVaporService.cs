namespace POCSQLCO.Models
{
    public interface IVaporService
    {
        IEnumerable<ContenuCommande> FindAllContenuCommandesByUtilisateurAndCommandeNonTerminee(Utilisateur utilisateur);
        ContenuCommande? FindContenuCommandeByUtilisateurAndJeu(int jeuId, int utilisateurId);
        Commande? FindCommandeNonTermineByUtilisateur(Utilisateur utilisateur);
        IEnumerable<Jeu> FindJeuxWithUtilisateur(Utilisateur utilisateur);
        Jeu FindJeuByJaquette(String jaquette);
        string FindUtilisateurHashPassword(Utilisateur utilisateur);
        Utilisateur FindUtilisateurByPseudo(string? pseudo);

        IEnumerable<Genre> FindAllGenres();
        void InsertGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        Genre? FindGenreById(int id);

        IEnumerable<Commande> FindAllCommandes();
        void InsertCommande(Commande commande);
        void UpdateCommande(Commande commande);
        void DeleteCommande(Commande commande);
        Commande? FindCommandeById(int id, int utilisateurId);

        IEnumerable<Theme> FindAllThemes();
        void InsertTheme(Theme theme);
        void UpdateTheme(Theme theme);
        void DeleteTheme(Theme theme);
        Theme? FindThemeById(int id);

        IEnumerable<ContenuCommande> FindAllContenuCommandes();
        void InsertContenuCommande(ContenuCommande contenuCommande);
        void UpdateContenuCommande(ContenuCommande contenuCommande);
        void DeleteContenuCommande(ContenuCommande contenuCommande);
        ContenuCommande? FindContenuCommandeById(int jeuId, int commandeId, int utilisateurId);

        IEnumerable<Developpeur> FindAllDeveloppeurs();
        void InsertDeveloppeur(Developpeur developpeur);
        void UpdateDeveloppeur(Developpeur developpeur);
        void DeleteDeveloppeur(Developpeur developpeur);
        Developpeur? FindtDeveloppeurById(int id);

        IEnumerable<Distributeur> FindAllDistributeurs();
        void InsertDistributeur(Distributeur distributeur);
        void UpdateDistributeur(Distributeur distributeur);
        void DeleteDistributeur(Distributeur distributeur);
        Distributeur? FindDistributeurById(int id);

        IEnumerable<Jeu> FindAllJeux();
        void InsertJeu(Jeu jeu);
        void UpdateJeu(Jeu jeu);
        void DeleteJeu(Jeu jeu);
        Jeu? FindJeuById(int id);

        IEnumerable<Notation> FindAllNotations();
        void InsertNotation(Notation notation);
        void UpdateNotation(Notation notation);
        void DeleteNotation(Notation notation);
        Notation? FindNotationById(int utilisateurId, int jeuId);

        IEnumerable<Utilisateur> FindAllUtilisateurs();
        void InsertUtilisateur(Utilisateur utilisateur);
        void UpdateUtilisateur(Utilisateur utilisateur);
        void DeleteUtilisateur(Utilisateur utilisateur);
        Utilisateur? FindUtilisateurById(int id);

    }
}
