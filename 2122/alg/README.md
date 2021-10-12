# Cvičení z Algoritmizace (úterý 12:20 v N8)

Na cvičení navazuje cvičení z **[Programování 1](https://lukyjanek.github.io/teaching/21-22/NPRG030.html)**, které vede kolega **Lukáš Kyjánek** (také v N8).
Studenti by měli být zapsaní na odpovídající cvičení neb program cvičení bude logicky provázán.

## Podmínky zápočtu

- Aktivní účast na cvičení.
- Nejméně **70%** bodů z domácích cvičení.
- Udělení zápočtu je **podmínkou** k účasti na zkoušce.

## Domácí úkoly

- Budeme používat [ReCodEx](https://recodex.mff.cuni.cz/), návod naleznete zde: https://github.com/ReCodEx/wiki/wiki/User-documentation.
- Úlohy budou zadávány zhruba ob-týden.
- Každá úloha bude bodována 10 body a jejich obtížnost se bude ztěžovat.
- Na úkol bude týden.
- Doporučuji začít řešit úlohy hned z počátku semestru.

## Co bylo na cvičení

### 5.10.2021

* Organizační info - viz. README v repozitáři
* Jsou dány rovnoramenné váhy a n kuliček.
  * Navrhněte algoritmus, který najde nejtěžší kuličku na co nejmenší počet vážení.
  * Nejtěžší i nejlehčí kuličku s použitím nejvýše 3⎣n/2⎦ vážení.
  * Druhou nejtěžší kuličku s použitím nejvýše n-2+⎡log2n⎤ vážení.
* Zadání DCV - lámání čokolády - viz ReCodEx.

### 12.10.2021

* Hint k DÚ: nešel by tam najít invariant? Není nějaký vztah,
  co by svázal počet kusů čokolády s počtem provedených zlomení?

* Skleničky a čaroděj:
  Jsme v temné místnosti se stolem. Stůl je čtvercový a v každém jeho rohu je sklenice, která je postavená buď dnem dolů, nebo dnem vzhůru.
  Naším cílem je otočit všechny slenice do stejné orientace. Můžeme vzít do rukou libovolné dvě sklenice, zjistit jak jsou orientované a pak každou libovolně otočit.

  V místnosti je čaroděj, který nás pustí ven, jakmile úlohu splníme (on nám řekne, kdy jsou všechny sklenice orientované stejně, my to vědět nemusíme).
  Ale nepustí nás zadarmo. Když se rozhodneme na dvě sklenice sáhnout, čaroděj může stolem otočit o libovolný násobek 90°,
  čímž sáhneme na jiné slenice, než jsme původně chtěli (to my ale nevíme).

  Dokážete vymyslet způsob, jak dostat všechny sklenice do jedné orientace?

  Pozn: Čaroděj otáčí stolem úmyslně pro nás špatně, takže otáčet sklenice náhodně nás nikam nedostane.
