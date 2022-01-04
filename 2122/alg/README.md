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
- Na úkol bude <strike>týden</strike> 1-2 týdny (v závislosti na úloze).
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

* Příklady na velké O, Omega a Theta:

  * n^2 = O(n^3)
  * n^3 = O(n^2)
  * f = O(g)  ->  g = O(f)

  Následující na rozmyšlení na doma, vrátíme se k nim na dalším cvičení:

  * f = O(g)  ->  g = OMEGA(f)
  * f = THETA(g)  ->  g = O(f)
  * f = O(g)  ->  1/f = O(g)
  * f = O(g)  ->  1/f = O(1/g)

### 19.10.2021

* Ukázána 2 řešení DÚ (invariand a matematická indukce)
* Prošli jsme poslední 4 tvrzení z minulého cvičení

* Nalezení prvku v setříďeném poli (listu)
  - Napsali jsme na tabuli algoritmus na binární vyhledávání a ukázali si detaily, které
    je dobré si rozmyslet.
    Skončili jsme s následujícím algoritmem (až na přejmenování identifikátorů):

  ```python3
  def binsearch(a, x):
      i = 0
      j = len(a) - 1
      k = (i + j) // 2

      # empty list
      if len(a) == 0:
          return -1

      while a[k] != x and i <= j:
          if x > a[k]:
              i = k + 1
          else:
              j = k - 1
          k = (i + j) // 2

      if a[k] == x:
          return k
      else:
          return -1
  ```

  - Jako rozšíření chceme nalézt index **j** největšího prvku **<= x**.
    Ukázali jsme si, že lze vyjíz t předchozího algoritmu a že je jenom třeba
    rozmyslet podmínky za cyklem. Dokončíme příště.

* Zadání DCV - prvočísla v intervalu - viz ReCodEx.

### 2.11.2021

* Dokončili jsme úlohu z minula na hledání největšího prvku **<= x**.

* Funkce co vrátí True pokud je uzávorkování ze znaků `()` správně.
* Stejná funkce, pokud máme `()[]` závorky. Už to tak lehce nepůjde jako v minulém případě.
  - Při více závorkách by se hodil nějaký dictionary, abych neduplikovali kód.

* Máme posloupnost celých čísel a chceme nalézt souvislý úsek takový, že má největší součet.
  S tím, že hledáme jenom sumu, není třeba vracet začátek a konec úseku.
  Tedy např. pro `[-10, 1, 5, 2, -2, 1]` je největší úsek `[1, 5, 2]` a má sumu 8.

  - Chceme algoritmus v čase O(N^3), O(N^2) a O(N). Poslední 2 varianty dokončíme příště.

* Zadání DCV - prioritní fronta - viz ReCodEx.

### 9.11.2021

* Dokončili jsme úlohu z minule - ukázali si algoritmus v čase O(N).

* Vypsat všechna korektní uzávorkování pomocí N párů závorek.

### 16.11.2021

* Vypsat všechny rostoucí posloupnosti tvořené čísly z množiny `{1, 2, ..., N}`.

* Začali jsme s jednosměrným spojovým seznamem pro:

  ```
  class Node:
    def __init__(self, value):
      self.value = value
      self.next = None
  ```

  Implementovali jsme metody **insert0** (přidávání na začátek), **size** (délka seznamu)
  a **append** (přidávání na konec).

* Zadání DCV - Rozklad čísla na K sčítanců - viz ReCodEx.

### 23.11.2021

* Ukázali jsme si řešení DCV - prioritní fronta.

* BVS (binární vyhledávací stromy) - ukázali jsme si základní metody jako nalezení
  maxima, určení počtu vrcholů a hloubky stromu.

* Nalezení jedné lehčí kuličky ze 7 stejných pomocí vážení na rovn. vahách.

### 30.11.2021

* Zabývali jsme se [Loydovou patnáctkou](https://en.wikipedia.org/wiki/15_puzzle) - ukázali jsme si
  jak reprezentovat stav, zda prohledávat do šířky či hloubky, jak velký je statový prostor, jaké použít
  datové struktury a tak dále. Na úloze jsme si ukázali, jak přistupovat k návrhu algoritmu.

### 7.12.2021

* Ukázali jsme si implementaci Loydovy patnácky a vyzkoušeli v praxi, jak se algoritmus chová pro různé velikosti,
  různé způsoby průchodu stavovým prostorem a jak dobrá řešení umí nalézt. Zopakovali jsme si principy jako prořezávání,
  heuristika a vhodné datové struktury.

### 14.12.2021

* Řešili jsme **problém batohu** v pseudo-polynomiálním čase a ukázali jsme si možné řešení úlohy.

### 21.12.2021

* Ukázali jsme si referenční řešení DCV - Průchod labyrintem
* Zopakovali jsme si reprezentace grafu v programu.
* Hledali jsme algoritmus, který vypíše počet trojúhelníků (K3) v grafu.
* Dále jsme měli zadaný strom a variantu orientovaných hran, které ukazují ke kořeni.
  Otázka zněla, zda se jedná o zakořeněný strom? Za doma na rozmyšlení, jak by se algoritmus změnil pokud
  by hrany ukazovaly od kořene k listům.

### 4.1.2022

* Zkusíme si naprogramovat úlohu z Advent of Code:
  https://adventofcode.com/2021/day/22

  **Tipy a úkoly pro úlohu**:

  * Stanovte složitost algoritmu a odhadněte počet kroků pro konkrétní vstup pro **Part One**.
  * Zkuste si každý cuboid uložit do třídy `Cuboid`.
  * Napište

    ```
    @classmethod
    def parse_line(cls, line):
    ...
    ```

    která naparsuje řádek vstupu, použije **list comprehension** (např. `[x for x in values if x == 12345]`)
    a vrátí instanci třídy `Cuboid`.

  * Naimplementujte funkci `Cuboid.contains_pixel(pixel)`, která vrátí `True` pokud bod (pixel) náleží do kvádru.

  **Úkoly pro Part Two**:

  * Napište metodu `Cuboid.fully_contains(self, other)`, která vrátí `True` pokud `other` kvádr je celý uvnitř `self`.
  * Napište metodu `Cuboid.intersects(self, other)`, která vrátí `True` pokud `other` kvádr
    má nějaký průnik s kvádrem `self`.

  **Příklad vstupu pro Part Two**:

  ```
  on x=-5..47,y=-31..22,z=-19..33
  on x=-44..5,y=-27..21,z=-14..35
  on x=-49..-1,y=-11..42,z=-10..38
  on x=-20..34,y=-40..6,z=-44..1
  off x=26..39,y=40..50,z=-2..11
  on x=-41..5,y=-41..6,z=-36..8
  off x=-43..-33,y=-45..-28,z=7..25
  on x=-33..15,y=-32..19,z=-34..11
  off x=35..47,y=-46..-34,z=-11..5
  on x=-14..36,y=-6..44,z=-16..29
  on x=-57795..-6158,y=29564..72030,z=20435..90618
  on x=36731..105352,y=-21140..28532,z=16094..90401
  on x=30999..107136,y=-53464..15513,z=8553..71215
  on x=13528..83982,y=-99403..-27377,z=-24141..23996
  on x=-72682..-12347,y=18159..111354,z=7391..80950
  on x=-1060..80757,y=-65301..-20884,z=-103788..-16709
  on x=-83015..-9461,y=-72160..-8347,z=-81239..-26856
  on x=-52752..22273,y=-49450..9096,z=54442..119054
  on x=-29982..40483,y=-108474..-28371,z=-24328..38471
  on x=-4958..62750,y=40422..118853,z=-7672..65583
  on x=55694..108686,y=-43367..46958,z=-26781..48729
  on x=-98497..-18186,y=-63569..3412,z=1232..88485
  on x=-726..56291,y=-62629..13224,z=18033..85226
  on x=-110886..-34664,y=-81338..-8658,z=8914..63723
  on x=-55829..24974,y=-16897..54165,z=-121762..-28058
  on x=-65152..-11147,y=22489..91432,z=-58782..1780
  on x=-120100..-32970,y=-46592..27473,z=-11695..61039
  on x=-18631..37533,y=-124565..-50804,z=-35667..28308
  on x=-57817..18248,y=49321..117703,z=5745..55881
  on x=14781..98692,y=-1341..70827,z=15753..70151
  on x=-34419..55919,y=-19626..40991,z=39015..114138
  on x=-60785..11593,y=-56135..2999,z=-95368..-26915
  on x=-32178..58085,y=17647..101866,z=-91405..-8878
  on x=-53655..12091,y=50097..105568,z=-75335..-4862
  on x=-111166..-40997,y=-71714..2688,z=5609..50954
  on x=-16602..70118,y=-98693..-44401,z=5197..76897
  on x=16383..101554,y=4615..83635,z=-44907..18747
  off x=-95822..-15171,y=-19987..48940,z=10804..104439
  on x=-89813..-14614,y=16069..88491,z=-3297..45228
  on x=41075..99376,y=-20427..49978,z=-52012..13762
  on x=-21330..50085,y=-17944..62733,z=-112280..-30197
  on x=-16478..35915,y=36008..118594,z=-7885..47086
  off x=-98156..-27851,y=-49952..43171,z=-99005..-8456
  off x=2032..69770,y=-71013..4824,z=7471..94418
  on x=43670..120875,y=-42068..12382,z=-24787..38892
  off x=37514..111226,y=-45862..25743,z=-16714..54663
  off x=25699..97951,y=-30668..59918,z=-15349..69697
  off x=-44271..17935,y=-9516..60759,z=49131..112598
  on x=-61695..-5813,y=40978..94975,z=8655..80240
  off x=-101086..-9439,y=-7088..67543,z=33935..83858
  off x=18020..114017,y=-48931..32606,z=21474..89843
  off x=-77139..10506,y=-89994..-18797,z=-80..59318
  off x=8476..79288,y=-75520..11602,z=-96624..-24783
  on x=-47488..-1262,y=24338..100707,z=16292..72967
  off x=-84341..13987,y=2429..92914,z=-90671..-1318
  off x=-37810..49457,y=-71013..-7894,z=-105357..-13188
  off x=-27365..46395,y=31009..98017,z=15428..76570
  off x=-70369..-16548,y=22648..78696,z=-1892..86821
  on x=-53470..21291,y=-120233..-33476,z=-44150..38147
  off x=-93533..-4276,y=-16170..68771,z=-104985..-24507
  ```