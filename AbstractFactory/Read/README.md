# .net_Theo

## Design Patterns ou patterns de conception 

![Premier Schema](image.png)

 ## Description des patterns

- nom 
- description
- exemple de code sous forme de diagramme UML
- la structure standard ( abstraite )
- un exemple de code 

## Cas concret d'etude pour ce cours

Nous allons prendre en exemple le cas d'une societe qui vend des vehicules en ligne. 

## Premiere grande famille de design pattern : les patterns de construction

Simplifier la création d'objet, qui devient abstraite, la standardiser .
On favorise l'utilisation d'interface entre les objets.

Exemple de patterns : singleton.
Le but est de cacher la création d'objet.    


### Le Pattern Abstract Factory

Le but de ce pattern est de permettre de fabriquer des objets regoupes en "famille" sans avoir a connaitre les classes cilbles destinee a  la fabrication de ces objets.

![Deuxieme Schema](image1.png)

### Le Pattern Builder

Ce pattern permet d'abstraire la construction d'objets complexes de leur implementation de sorte qu'un client puisse creer des objets complexes sans avoir a se preocuper des differences d'implementation.