
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace POCSQLCO.Models
{
    public class VaporService : IVaporService
    {
        private VaporContext _context;
        public VaporService(VaporContext context)
        {
            _context = context;
        }

        public Utilisateur FindUtilisateurByPseudo(string pseudo)
        {

            var sequenceQueryResult = _context.Database.SqlQuery<Utilisateur>($"SELECT * FROM Utilisateur WHERE pseudo = {pseudo}").FirstOrDefault();

            Utilisateur utilisateur = new Utilisateur();

            if (sequenceQueryResult != null)
            {
                utilisateur = sequenceQueryResult;
            }

            return utilisateur;
        }

        public void DeleteCommande(Commande commande)
        {
            try
            {
                _context.Commandes.Remove(commande);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteContenuCommande(ContenuCommande contenuCommande)
        {
            try
            {
                _context.ContenuCommandes.Remove(contenuCommande);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteDeveloppeur(Developpeur developpeur)
        {
            try
            {
                _context.Developpeurs.Remove(developpeur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteDistributeur(Distributeur distributeur)
        {
            try
            {
                _context.Distributeurs.Remove(distributeur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteGenre(Genre genre)
        {
            try
            {
                _context.Genres.Remove(genre);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteJeu(Jeu jeu)
        {
            try
            {
                _context.Jeux.Remove(jeu);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteNotation(Notation notation)
        {
            try
            {
                _context.Notations.Remove(notation);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteTheme(Theme theme)
        {
            try
            {
                _context.Themes.Remove(theme);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                _context.Utilisateurs.Remove(utilisateur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Commande? GetCommandeById(int id, int utilisateurId)
        {
            try
            {
                return _context.Commandes.Find(id, utilisateurId);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Commande> GetCommandes()
        {
            try
            {
                return _context.Commandes.ToList();
            }
            catch
            {
                throw;
            }
        }

        public ContenuCommande? GetContenuCommandeById(int jeuId, int commandeId)
        {
            try
            {
                return _context.ContenuCommandes.Find(commandeId, jeuId);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ContenuCommande> GetContenuCommandes()
        {
            try
            {
                return _context.ContenuCommandes.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Developpeur? GetDeveloppeurById(int id)
        {
            try
            {
                return _context.Developpeurs.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Developpeur> GetDeveloppeurs()
        {
            try
            {
                return _context.Developpeurs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Distributeur? GetDistributeurById(int id)
        {
            try
            {
                return _context.Distributeurs.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Distributeur> GetDistributeurs()
        {
            try
            {
                return _context.Distributeurs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Genre? GetGenreById(int id)
        {
            try
            {
                return _context.Genres.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Genre> GetGenres()
        {
            try
            {
                return _context.Genres.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Jeu? GetJeuById(int id)
        {
            try
            {
                return _context.Jeux.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Jeu> GetJeux()
        {
            try
            {
                return _context.Jeux.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Notation? GetNotationById(int utilisateurId, int jeuId)
        {
            try
            {
                return _context.Notations.Find(utilisateurId, jeuId);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Notation> GetNotations()
        {
            try
            {
                return _context.Notations.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Theme? GetThemeById(int id)
        {
            try
            {
                return _context.Themes.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Theme> GetThemes()
        {
            try
            {
                return _context.Themes.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Utilisateur? GetUtilisateurById(int id)
        {
            try
            {
                return _context.Utilisateurs.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Utilisateur> GetUtilisateurs()
        {
            try
            {
                return _context.Utilisateurs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertCommande(Commande commande)
        {
            try
            {
                _context.Commandes.Add(commande);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertContenuCommande(ContenuCommande contenuCommande)
        {
            try
            {
                _context.ContenuCommandes.Add(contenuCommande);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertDeveloppeur(Developpeur developpeur)
        {
            try
            {
                _context.Developpeurs.Add(developpeur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertDistributeur(Distributeur distributeur)
        {
            try
            {
                _context.Distributeurs.Add(distributeur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertGenre(Genre genre)
        {
            try
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertJeu(Jeu jeu)
        {
            try
            {
                _context.Jeux.Add(jeu);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertNotation(Notation notation)
        {
            try
            {
                _context.Notations.Add(notation);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertTheme(Theme theme)
        {
            try
            {
                _context.Themes.Add(theme);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                _context.Utilisateurs.Add(utilisateur);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateCommande(Commande commande)
        {
            try
            {
                var local = _context.Set<Commande>().Local.FirstOrDefault(entry => entry.Id.Equals(commande.Id) && entry.Id.Equals(commande.UtilisateurId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(commande).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateContenuCommande(ContenuCommande contenuCommande)
        {
            try
            {
                var local = _context.Set<ContenuCommande>().Local.FirstOrDefault(entry => entry.CommandeId.Equals(contenuCommande.CommandeId) && entry.UtilisateurId.Equals(contenuCommande.UtilisateurId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(contenuCommande).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            try
            {
                var local = _context.Set<Developpeur>().Local.FirstOrDefault(entry => entry.Id.Equals(developpeur.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(developpeur).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateDistributeur(Distributeur distributeur)
        {
            try
            {
                var local = _context.Set<Distributeur>().Local.FirstOrDefault(entry => entry.Id.Equals(distributeur.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(distributeur).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateGenre(Genre genre)
        {
            try
            {
                var local = _context.Set<Genre>().Local.FirstOrDefault(entry => entry.Id.Equals(genre.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(genre).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateJeu(Jeu jeu)
        {
            try
            {
                var local = _context.Set<Jeu>().Local.FirstOrDefault(entry => entry.Id.Equals(jeu.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(jeu).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNotation(Notation notation)
        {
            try
            {
                var local = _context.Set<Notation>().Local.FirstOrDefault(entry => entry.UtilisateurId.Equals(notation.UtilisateurId) && entry.JeuId.Equals(notation.JeuId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(notation).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateTheme(Theme theme)
        {
            try
            {
                var local = _context.Set<Theme>().Local.FirstOrDefault(entry => entry.Id.Equals(theme.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(theme).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                var local = _context.Set<Utilisateur>().Local.FirstOrDefault(entry => entry.Id.Equals(utilisateur.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(utilisateur).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
