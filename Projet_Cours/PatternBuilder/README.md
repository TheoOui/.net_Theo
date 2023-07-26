# Projet_Pattern Azouz Théo

## Pattern de construction
La classe FootballPlayerBuilder utilise le Pattern Builder car il permet de construire un objet Football Player étape par étape.
On peut donc créer des joueurs avec différentes stats de manière flexible.

La classe Football Team utilise le Singleton Pattern car il garantit qu'il n'y a qu'une seule instance de la classe FootballTeam dans l'application et elle est accessible grâce à la méthode statique 'GetInstance()'

utilisation du Pattern Prototype, je clone un objet type de FootballPlayer en l'occurence ici les stats des joueurs et j'ajoute une note bonus pour chaque stats pour montrer une version boosté du joueur en question 

## Pattern de Structuration

Utilisation du Pattern Adapter pour faire le lien entre INoteDisplayAdapter et la classe FootballPlayer sans modifier le code de cette dernière.
Ca permet de rendre mon code plus flexible et évite de modifier la classe FootballPlayer.
Il permet d'adapter une interface existante à une autre interface attendue.


## Pattern de comportement 
Utilisation de Pattern Strategy avec une stratégie permettant de calculer la note globale et une stratégie qui nous ressors si le joueur à + de 85 de Dribble alors c'est un bon dribbleur. 
En créant l'interface INoteCalculationStrategy et ses implémentations GlobalRatingStrategy et DribbleRatingStrategy, on peut facilement alterner entre différentes stratégies de calcul sans modifier le code des joueurs ou de l'équipe.


