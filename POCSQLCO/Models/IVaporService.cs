namespace POCSQLCO.Models
{
    public interface IVaporService
    {
        IEnumerable<Genre> FindAllGenres();
        void InsertGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        Genre? FindGenreById(int id);

        Commande? FindCommandeNonTermineByUtilisateur(Utilisateur utilisateur);
        IEnumerable<Commande> FindAllCommandesTermineByUtilisateur(Utilisateur utilisateur);
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

        ContenuCommande? FindContenuCommandeByUtilisateurAndJeu(int jeuId, int utilisateurId);
        IEnumerable<ContenuCommande> FindAllContenuCommandesByUtilisateurAndCommandeNonTerminee(Utilisateur utilisateur);
        ContenuCommande FindContenuCommandesByUtilisateurAndJeuAndCommandeNonTerminee(Utilisateur utilisateur, Jeu jeu);
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

        Jeu FindJeuByJaquette(String jaquette);
        IEnumerable<Jeu> FindJeuxWithUtilisateur(Utilisateur utilisateur);
        IEnumerable<Jeu> FindJeuxWithUtilisateurAndGenre(Utilisateur utilisateur, String genreLibelle);
        IEnumerable<Jeu> FindJeuxByGenre(String genreLibelle);
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

        Utilisateur FindUtilisateurByPseudo(string? pseudo);
        string FindUtilisateurHashPassword(Utilisateur utilisateur);
        IEnumerable<Utilisateur> FindAllUtilisateurs();
        void InsertUtilisateur(Utilisateur utilisateur);
        void UpdateUtilisateur(Utilisateur utilisateur);
        void DeleteUtilisateur(Utilisateur utilisateur);
        Utilisateur? FindUtilisateurById(int id);

    }
}
