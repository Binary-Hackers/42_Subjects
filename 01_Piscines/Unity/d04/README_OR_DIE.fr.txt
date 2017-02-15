********************************************************************************

                   README_OR_DIE.fr.txt for Piscine Unity
                   Created on : Mon Jun  8 15:55:02 2015
                   Made by : David "Thor" GIRON <thor@42.fr>

********************************************************************************


- Pour lancer la demo du jour, executez le fichier "demoDxx.app" avec
  la commande : "open ./demoDxx.app", ou "Dxx" correspond bien entendu
  au jour present.

- Le jeu est concu pour etre joue dans une resolution 16/9, nous vous
  conseillons donc de le lancer en 1280x720, 1600x900 ou 2560x1440 pour
  une experience optimale.

- Aujourd'hui, on vous fournit le projet complet a
  utiliser. Dezipez le fichier "projetDxx.tar.gz" et copiez
  son contenu a la racine de votre depot conformement aux consignes
  generales. Dans ce cas, les assets que nous vous fournissons se
  trouveront deja dans le projet.

- Les assets fournis pendant cette piscine sont la propriete de leurs
  auteurs respectifs et ne peuvent etre utilises qu'a des fins
  pedagogiques. Vous ne pouvez donc pas les redistribuer librement.


********************************************************************************

Section spéciale précisions car il y en a beaucoup aujourd'hui :

--------------------
GAMEPLAY DE LA DEMO
--------------------

- Les commandes du jour :
    - Return/Entrée pour valider
    - Les flèches de direction || WASD pour sélectionner un niveau
    - Gauche/Droite || A/D pour aller vers la gauche ou vers la droite
    - S ou Fleche bas pour se baisser a l'arret ou pour se mettre en boule
      lorsque Sonic court assez rapidement.
    - Espace pour sauter
    - En maintenant la touche sur Bas espace permet de charger le super spin.
      En appuyant plusieurs fois on charge de plus en plus. Ensuite il suffit de
      relacher la touche bas pour être éjecté en avant.
    - Command + Q pour quitter le jeu.
    - Backspace pour redémarrer le niveau.
    - Suppr pour retourner au Data Select.


- Les tramplins naturels et les bumpers donnent plus de boost en etant en boule.

- Les pièces indiquent souvent des trajectoires intéressantes à suivre pour passer
  les obstacles. Souvent ne veut pas dire toujours .... ;)

- Il n'y a aucun passage impossible mais certains sont plus techniques que d'autres.
  Pour tous les passages impliquant des bumpers les trajectoires a suivres sont
  souvent représentées par des pièces. Si vous êtes trop bas essayez de prendre le
  bumper en roulant plutôt qu'en courant.

- L'ordre des niveaux est différent suivant la route. Si vous n'avez jamais joué à
  Sonic je vous conseille la route Moderne, c'est la plus équilibrée pour apprendre.

- Les plateformes de Oil Ocean sont en rythme avec la version de la route Dubstep
  si ça peut vous aider à les passer.

- Contrairement au vrai Sonic on ne meurt pas si on se fait coincer sous une
  plateforme, histoire de simplifier les choses un peu…

- Et enfin il n'y a pas de points de contrôle mais les vies sont infinies. Ça tombe
  bien le jeu est plutôt hardcore. Si vous n'arrivez vraiment pas à passer un niveau
  demandez à votre voisin de gauche ou votre voisin de droite.


------------------------------
CONSEILS PAR RAPPORT AU PROJET
------------------------------

- Je vous ai remis l'AutoSnap d'hier. Utilisez le pour mettre vos niveaux en place
  plus facilement. Vous pouvez régler le pas de la grille dans les paramètres de
  l'autosnap. Il peut être intéressant de travailler en 0.5 ou 0.25 pour placer les
  bumpers, pics et pièces.

- De façon générale évitez de toucher aux paramètres public du script Sonic ainsi
  qu'aux Matériaux physiques si vous ne voulez pas flinguer la physique du personnage.

- Je vous ai fourni quelques préfabs de blocs de niveaux déjà tous prêts mais vous
  avez également les planches de sprites prédécoupées si vous voulez en créer d'autres.
  Voici la marche à suivre :
    * Mettez le tag du bloc sur "ground"
    * Créez un premier Collider2D qui servira a gérer les collisions et éviter que
      Sonic passe à travers le bloc.
    * Créez un second Collider2D en mode isTrigger. Vous devez placer cette zone sur le
      dessus du bloc car c'est celle-ci qui permettra à Sonic de sauter.
  Vous pouvez prendre en exemple les blocs déjà fournis.

- Les blocs les plus simples à utiliser pour créer un premier niveau sont ceux d'Oil
  Ocean.

Bon courage.
