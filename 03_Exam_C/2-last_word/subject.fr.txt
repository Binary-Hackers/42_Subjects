Assignment name  : last_word
Expected files   : last_word.c
Allowed functions: write
--------------------------------------------------------------------------------

Écrire un programme qui prend une chaîne de caractères en paramètre, et qui
affiche le dernier mot de cette chaîne, suivi d'un '\n'.

On appelle "mot" une portion de chaîne de caractères délimitée soit par des
espaces et/ou des tabulations, soit par le début / fin de la chaîne.

Si le nombre de paramètres transmis est différent de 1, ou s'il n'y a aucun mot
à afficher, le programme affiche '\n'.

Exemple:

$> ./last_word "FOR PONY" | cat -e
PONY$
$> ./last_word "this        ...       is sparta, then again, maybe    not" | cat -e
not$
$> ./last_word "   " | cat -e
$
$> ./last_word "a" "b" | cat -e
$
$> ./last_word "  lorem,ipsum  " | cat -e
lorem,ipsum$
$>
