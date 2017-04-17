using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGSB.Models
{
    public class DatabaseSeedData
    {
        private ApigsbDbContext _context;

        public DatabaseSeedData(ApigsbDbContext context)
        {
            _context = context;
        }

        public async Task SeedData()
        {
            if (!_context.Visiteur.Any())
            {
                #region Seed Visiteurs
                List<Visiteur> visiteurs = new List<Visiteur>();
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Villechalane",
                    Prenom = "Louis",
                    Matricule = "4A4E",
                    Telephone = "0651459865"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Bedos",
                    Prenom = "Christian",
                    Matricule = "5B5F",
                    Telephone = "0789458565"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Debelle",
                    Prenom = "Michel",
                    Matricule = "6C6G",
                    Telephone = "0635452568"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Debelle",
                    Prenom = "Jeanne",
                    Matricule = "7D7H",
                    Telephone = "0627286542"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Debroise",
                    Prenom = "Michel",
                    Matricule = "8E8I",
                    Telephone = "0321587565"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Desmarquest",
                    Prenom = "Nathalie",
                    Matricule = "9F9J",
                    Telephone = "0625456875"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Frémont",
                    Prenom = "Fernande",
                    Matricule = "2D4G",
                    Telephone = "0359865478"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Cottin",
                    Prenom = "Vincenne",
                    Matricule = "2K9Q",
                    Telephone = "0645967823"
                });
                visiteurs.Add(new Visiteur()
                {
                    Nom = "Gest",
                    Prenom = "Alain",
                    Matricule = "5G8K",
                    Telephone = "788365124"
                });
                #endregion Seed Visiteur

                _context.Visiteur.AddRange(visiteurs);

                if (!_context.Pathologie.Any())
                {
                    #region Seed Pathologies
                    List<Pathologie> pathologies = new List<Pathologie>();
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Acné sévère"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Acné polymorphe juvénile"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Acné comédonienne"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Acné microkystique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Manifestation mineure de l'anxiété"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Prémédication anesthésique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Urticaire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Insomnie infantile"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Pneumopathie aiguë"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Exacerberation de bronchite chronique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Otite"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection gynécologique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection digestive"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Maladie de Lyme"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Septicémie"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Bronchite aiguë"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection stomatologique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Sinusite"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection urinaire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection génitale masculine"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Infection biliaire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Endocardite"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Arthrose"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Polyarthrite rhumatoïde"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Douleur du tube digestif"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Colique néphrétique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Douleur des voies biliaires"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Etat de mal épileptique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Asthme persistant léger à modéré"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Asthme induit par l'effort"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Asthme avec rhinite allergique saisonnière"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer colorectal métastatique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer du rein"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer des trompes de Fallope"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Carcinome du col de l'utérus"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer du sein métastatique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer péritonéal primitif"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Carcinome épithélial de l'ovaire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Cancer gastrique avancé"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Hypercalcémie induite par des tumeurs"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Contraception orale"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Contraception intra-utérine"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Ménorragie fonctionnelle"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Contraception d'urgence"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Episode dépressif majeur"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Anxiété généralisée"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Trouble obsessionnel compulsif"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Phobie sociale"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Etat de stress post-traumatique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Douleur neuropathique périphérique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Enurésie nocturne non organique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Diabète de type 2"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Diabète non insulinodépendant"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Complications liées au diabète de type 2"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Diarrhée chronique"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Diarrhée aiguë"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Fièvre"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Dans dans l'arthrose"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Crise de migraine avec ou sans aura"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Etat fébrile"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Rhumatisme inflammatoire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Rhumatisme articulaire aigu chez l'enfant"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Brûlure superficielle peu étendue"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Plaie superficielle peu étendue"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Douleur"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Aménorrhée secondaire"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Syndrome prémenstruel"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Endométriose"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Ménopause"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Ménométorragie"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Dysménorrhée"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Mastopathie bénigne"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Etat anxieux"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Troubles mineurs du sommeil"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Insomnie occasionnelle"
                        }
                    );
                    pathologies.Add(
                        new Pathologie()
                        {
                            Libelle = "Insomnie transitoire"
                        }
                    );
                    #endregion Seed Pathologies   

                    _context.Pathologie.AddRange(pathologies);
                }

                if (!_context.Excipient.Any())
                {
                    #region Seed Excipients

                    List<Excipient> excipients = new List<Excipient>();
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Amidon de maïs"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Amidon"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Silice (E551)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Stéarique acide (E570)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Saccharose"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Amidon de pomme de terre"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Polysorbate 80 (E433)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Macrogol 6000"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Povidone (E1201)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Titane dioxyde (E171)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Calcium carbonate"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Talc (E553b)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Cire de carnauba (E903)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Gomme laque (E904)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Fer oxyde (E172)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "N-butylalcool"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Eau purifiée"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Propylèneglycol (E1520)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Isopropylique alcool"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Ammonium hydroxyde (E528)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Huile de soja"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Cire d'abeille jaune"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Huile végétale"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Glycérol (E422)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Butylhydroxytoluène (E321)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Hydroxypropylcellulose (E463)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Lactose"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Cellulose microcristalline (E460)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Silice colloïdale"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Magnésium stéarate (E572)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Hypromellose (E464)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Macrogol 400"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Citrique acide (E330)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sodium benzoate (E211)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Géranium"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Benzoïque aldéhyde"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Vanille"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Toluique aldéhyde"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Ethylmaltol"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Gomme arabique (E414)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Glucose"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sorbitol (E420)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sodium"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sodium laurysulfate (E487)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Croscarmellose sodique (E468)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Gélatine"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sorbitane monolaurate (E432)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Indogitine (E132)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Polyvinyle acétate"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Amidon de blé"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Polyvnyle acétate"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Erythrosine (E127)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Ethanol"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Benzylique alcool"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sodium docusate"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Hyprolose (E463)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Polysorbate 20"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Protéines de hamster"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Tréhalose"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Mannitol (E421)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sodium citrate (E331)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Crospovidone (E1202)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Triacétine"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Polysorbate 80"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Macrogol 8000"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Siméticone"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Sorbique acide (E200)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Glycérides"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Méthylcellulose (E461)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Gomme xanthane (E415)"
                        }
                    );
                    excipients.Add(
                        new Excipient()
                        {
                            Libelle = "Cire de lignite"
                        }
                    );
                    #endregion Seed Excipients

                    _context.Excipient.AddRange(excipients);
                }

                if (!_context.Famille.Any())
                {
                    #region Seed Familles
                    List<Famille> familles = new List<Famille>();
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Acné",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Allergies",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Antibiotiques",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Anti-inflammatoires",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Antispasmodiques",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Anxiété",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Asthme",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Cancer",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Cholestérol",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Coagulation",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Contraception",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Dépression",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Diabètes",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Diarrhée",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Douleur",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Hormones",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Insomnie - nervosité",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Nausées - vomissements",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Obésité",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Stérilité - infertilité",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Thyroïde",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Troubles érectiles",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Troubles psychiatriques",
                        }
                    );
                    familles.Add(
                        new Famille()
                        {
                            Nom = "Ulcère",
                        }
                    );
                    #endregion Seed Familles

                    _context.Famille.AddRange(familles);
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
