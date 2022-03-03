# Cvičení z Programování 2 (pátek 10:40 v N11)

Cvičení navazuje na Programování 1 z minulého semestru.

## Podmínky zápočtu

- Aktivní účast na cvičení.
- Nejméně **70%** bodů z domácích cvičení.
  * Opět budeme používat [Recodex](https://recodex.mff.cuni.cz/).
  * Úlohy budou zadávány zhruba ob-týden.
  * Každá úloha bude bodována 10 body a jejich obtížnost se bude ztěžovat.

- **Zápočtový test** - Podobně jako v zimním semestru bude třeba naprogramovat funkční řešení zadané úlohy za 90 min.
  Během testu bude možné používat libovolné poznámky, slajdy, dokumentaci jazyka atd.
  První bude na posledním cvičení, další termíny budou během zkouškového období dle potřeby.

- **Zápočtový program** - Rozumně složitý program v jazyce C#.
  * Zadání zápočtového programu musí být schválené do **1.5.** (2 studenti nebudou mít stejné zadání) a pak
    na něm začnete pracovat.
  * Odevzdání programu bude do **1.9.** (ale ideálně dříve) s tím, že program Vám projdu, okomentuju
    a poté se domluvíme na předvedení (ideálně v online formě).
  * Součástí bude uživatelská a programátorská dokumentace.

  Inspirovat se můžete zde (ne všechny příklady jsou ale dostatečně obtížné, někdy lze obtížnost upravit přidáním pěkného GUI):
  [Martin Mareš](http://mj.ucw.cz/vyuka/zap/),
  [Michal Žemlička](http://www.ms.mff.cuni.cz/~zemlicka/vyuka/NMIN101/namety/) a
  [Lenka Forstová](https://www.ms.mff.cuni.cz/~forstova/pgmZ/Zapoctaky.html).

  Rudolf Kryl má na webu [návod na psaní dokumentace k zápočťáku](https://ksvi.mff.cuni.cz/~kryl/dokumentace.htm),
  také doporučuji přečíst.

  Byl bych rád, kdybyste program vyvíjeli v repozitáři na GitHubu nebo GitLabu, případně podobné službě.
  Ušetří to práci oběma stranám. Pokud s gitem neumíte, pak máte ideální příležitost se ho naučit, budete ho beztak jednou potřebovat ([Git ve 100 sekundách](https://www.youtube.com/watch?v=hwP7WQkmECE&ab_channel=Fireship),
  ale nám stačí prvních 60 a potom to samé, [ale detailněji](https://www.youtube.com/watch?v=HkdAHXoRtos&ab_channel=Fireship)).


## Co bylo na cvičení

### 18.2.2022 (1. cvičení)

* Organizační info - viz. README v repozitáři

#### Založení projektu v C#, předklad a spuštění programu

Postupujte [dle hezkého návodu](https://gimli.ms.mff.cuni.cz/~topfermi/vyuka/2122/NPRG031/#uzitecne-info) od kolegy M. Töpfera.

#### Úlohy k procvičování

Doporučuju si otevřít [první přednášku](https://ksvi.mff.cuni.cz/~holan/Pgm-2_2021_01.pdf) a hledat v ní.

##### Vstup a Výstup

1. Napiště program, který se optá na jméno a pak ho osloví: např. `Hello Martin`.
   Zkuste pro výstup použít [$-notaci](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated). 

##### Cykly

1. Vypište čísla od 1 do `N`, která nejsou dělitelná 3.
1. Sečtěte čísla od 1 do `N`.
1. Upravte program, aby sčítal jen násobky 3 a 5. Např. pro `N=17` je správný výsledek `60`.
1. Najděte maximum z pole čísel.
1. Najděte pozice všech největších prvků v poli.
1. Vypište příštích 20 přestupných let.

##### Switch

1. Za použití klíčového slova `switch`, vypiště pro daný string počet znaků, kterou jsou buď `samohláska`,
   `mezera` a nebo `tečka` (můžete vyzkoušet použití `foreach` cyklu).
1. Pro dané číslo vypište text `dělitelné třemi`, `dělitelné sedmi` nebo `dělitelné deseti` pokud dané číslo
   splňuje danou dělitelnost.

##### Funkce

1. Napište funkci, která vrací minimum ze svých třech celočíselných argumentů.
1. Napište funkci `Compare`, která dostane dvě čísla a, b a vrací 1 pro a > b, 0 pro a == b a -1 pro a < b.
   Místo 1 a -1 se dají použít libovolná kladná a záporná čísla. To je standardní způsob, jak se v C# udává výsledek porovnání.
   (Šlo by to udělat i bez porovnání? Jak se to bude chovat pro vstup např. `Int32.MinValue` a `Int32.MaxValue`)?
1. Napište funkci `IsPositive(n)`, která přijme celé číslo jako argument a vrací true, je-li číslo nezáporné.
1. Nyní napište funkci `IsNegativeOrZero(n)`, která vrací true, není-li n kladné. Využijte funkci z předešlého bodu.
1. Napište funkci, která počítá ciferný součet čísla.


### 25.2.2022 (2. cvičení)

#### Úlohy k procvičování

1. Napiště funkci `IsPalindromic`, která pro daný řetězec vrátí `true` pokud je palindrom (např. `kajak`), jinak `false`.
1. Implementujte funkci `MostFrequentWord`, která dostane na vstupu řetězec. Ten rozdělte na slova (mezera odděluje slovo)
a vraťte nejčastější slovo. Použijte třídu `Dictionary`.
1. Napiště funkci, která vrátí pole `int[]` v opačném pořadí. Pole modifikujte "in place", bez volání funkce `Array.Reverse` nebo
podobné funkce.
1. Napiště funkci, která udělá interleave 2 polí, tedy např. pro `[1, 2, 3]` a `[10, 11, 12]` vrátí `[1, 10, 2, 11, 3, 12]`.
Můžete předpokládat, že pole jsou stejně dlouhá.
1. Napiště funkci, která udělá rotaci o `n` prvků, tedy prvních `n` prvků dá na konec pole. Podobně jako v minulém bodě, implementujte
"in place". Tedy pro `[1, 2, 3, 4, 5]` a `n=2` bude výsledek `[3, 4, 5, 1, 2]`.
1. Implementujte funkci `FindMinMax`, která vrátí `tuple` `(int min, int max)`, jenž obsahuje minimum a maximum pro pole hodnot na vstupu.
Dokumentaci k `tuple` naleznete [zde](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples).
1. Vytvořte dvě množiny třídy `HashSet`, do první vložte sudá kladná číslo menší než 20. Do druhé pak kladná čísla dělitelná 6 menší než 100.
Poté vypiště průnik, sjednocení a rozdíl obo množin.
1. Implementujte libovolný sort (bubble sort, insert sort, select sort).


##### String

1. Pro daný string na vstupu (např. `Hello world.` vraťte podřetězec, který je obdobou následujících Python příkazů. Použijte
   volání funkce `Substring`:

  ```
  s[5:]
  s[1:5]
  s[:-3]
  s[-5:]
  s[-5:-3]
  s[4]
  s[-1]
  s[::-1]
  s[1::2]
  ```

### 4.3.2022 (3. cvičení)

#### Úlohy k procvičování

Implementujte 2 třídy (`Square` a `Circle`), které budou implementovat následující `interface`:

```c#
interface IShape
{
    string Describe();

    void Print();

    bool MultiplySize(int multiplier);

    decimal Surface { get; }
    decimal Perimeter { get; }

    bool Transparent { get; set; }
}
```

