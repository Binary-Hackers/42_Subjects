Assignment name  : repeat_alpha
Expected files   : repeat_alpha.c
Allowed functions: write
--------------------------------------------------------------------------------

Écrire un programme repeat_alpha qui prend une chaîne et l'affiche en répétant
chaque caractère alphabétique autant de fois que son index dans l'alphabet,
suivie d'un newline.

'a' devient 'a', 'b' devient 'bb', 'e' devient 'eeeee', etc...

La casse ne change pas.

Si le nombre d'arguments n'est pas 1, affiche juste un newline.

Exemples:

$>./repeat_alpha "abc"
abbccc
$>./repeat_alpha "Alex." | cat -e
Alllllllllllleeeeexxxxxxxxxxxxxxxxxxxxxxxx.$
$>./repeat_alpha 'abacadaba 42!' | cat -e
abbacccaddddabba 42!$
$>./repeat_alpha | cat -e
$
$>
$>./repeat_alpha "" | cat -e
$
$>
