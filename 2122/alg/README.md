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
