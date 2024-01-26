namespace POCSQLCO.Models
{
    public interface IVaporService
    {

        string FindUtilisateurHashPassword(Utilisateur utilisateur);
        Utilisateur FindUtilisateurByPseudo(string? pseudo);

        IEnumerable<Genre> GetGenres();
        void InsertGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        Genre? GetGenreById(int id);

        IEnumerable<Commande> GetCommandes();
        void InsertCommande(Commande commande);
        void UpdateCommande(Commande commande);
        void DeleteCommande(Commande commande);
        Commande? GetCommandeById(int id, int utilisateurId);

        IEnumerable<Theme> GetThemes();
        void InsertTheme(Theme theme);
        void UpdateTheme(Theme theme);
        void DeleteTheme(Theme theme);
        Theme? GetThemeById(int id);

        IEnumerable<ContenuCommande> GetContenuCommandes();
        void InsertContenuCommande(ContenuCommande contenuCommande);
        void UpdateContenuCommande(ContenuCommande contenuCommande);
        void DeleteContenuCommande(ContenuCommande contenuCommande);
        ContenuCommande? GetContenuCommandeById(int jeuId, int commandeId);

        IEnumerable<Developpeur> GetDeveloppeurs();
        void InsertDeveloppeur(Developpeur developpeur);
        void UpdateDeveloppeur(Developpeur developpeur);
        void DeleteDeveloppeur(Developpeur developpeur);
        Developpeur? GetDeveloppeurById(int id);

        IEnumerable<Distributeur> GetDistributeurs();
        void InsertDistributeur(Distributeur distributeur);
        void UpdateDistributeur(Distributeur distributeur);
        void DeleteDistributeur(Distributeur distributeur);
        Distributeur? GetDistributeurById(int id);

        IEnumerable<Jeu> GetJeux();
        void InsertJeu(Jeu jeu);
        void UpdateJeu(Jeu jeu);
        void DeleteJeu(Jeu jeu);
        Jeu? GetJeuById(int id);

        IEnumerable<Notation> GetNotations();
        void InsertNotation(Notation notation);
        void UpdateNotation(Notation notation);
        void DeleteNotation(Notation notation);
        Notation? GetNotationById(int utilisateurId, int jeuId);

        IEnumerable<Utilisateur> GetUtilisateurs();
        void InsertUtilisateur(Utilisateur utilisateur);
        void UpdateUtilisateur(Utilisateur utilisateur);
        void DeleteUtilisateur(Utilisateur utilisateur);
        Utilisateur? GetUtilisateurById(int id);

    }
}
