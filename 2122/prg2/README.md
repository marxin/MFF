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

  Byl bych rád, kdybyste program vyvíjeli v repozitáři ~~na GitHubu~~ nebo GitLabu
  (preferovaný je [školní instance](https://gitlab.mff.cuni.cz)), případně podobné službě.
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
    /* Return description of a shape.
       Examples: "Square[3x3]" where 3 is edge size of the square
                 "Circle[4]" where 4 is diameter of the circle
       */
    string Describe();

    /* Print to console the shape:

       ##
       ##

       will be printed for a Square with size == 2.

       ...
       ...
       ...

       will be printed for a Square with size == 3 that is transparent.

       For circles, print 'o' * diameter for non-transparent Circle,
       and '.' * diameter for transparent one.

       Example:
       ooooo

       circle with d == 5

       */
    void Print();

    /* Multiple size of a shape if the multiplier is positive number.
       In that case, true is returned. Otherwise, false is returned
       and the shape is unchanged. */
    bool MultiplySize(int multiplier);

    /* Get surface of the shape. Note the return type. */
    decimal Surface { get; }

    /* Get perimeter of the shape. Note the return type. */
    decimal Perimeter { get; }

    /* Property if object is transparent or not.
       By default an object is not transparent. */
    bool Transparent { get; set; }
}
```

Vygenerovaná implementace:

```c#
class MyTestShape : IShape
{
    public decimal Surface => throw new NotImplementedException();

    public decimal Perimeter => throw new NotImplementedException();

    public bool Transparent
    {
        get
        {
           throw new NotImplementedException();
        }

        set
        {
           throw new NotImplementedException();
        }
    }

    public string Describe()
    {
        throw new NotImplementedException();
    }

    public bool MultiplySize(int multiplier)
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}
```

S tím, že obě trídy budou implementovat konstruktory a na otestování Vám pomůže následující kód:

```c#
using System;
using System.Diagnostics;

/* 1) testing square operations */
var square = new Square(2, true);
Console.WriteLine(square.Describe());
square.Print();

bool result = square.MultiplySize(0);
Debug.Assert(!result);
result = square.MultiplySize(2);
Debug.Assert(result);
Debug.Assert(square.Perimeter == 16);

square.Transparent = false;
Console.WriteLine();
square.Print();
Debug.Assert(square.Describe() == "Square[4x4]");

Console.WriteLine();

/* 2) testing circle operations */
var circle = new Circle(5);
circle.Print();
result = circle.MultiplySize(-5);
Debug.Assert(!result);
result = circle.MultiplySize(2);
Debug.Assert(result);
Debug.Assert(circle.Surface > 78m && circle.Surface < 79m);

Console.WriteLine();
circle.Print();
Console.WriteLine();

/* 3) shapes in container */
IShape[] shapes = new IShape[] { new Square(1), new Square(4), new Circle(5, false)};
foreach(IShape shape in shapes)
{
  shape.MultiplySize(2);
  Console.WriteLine(shape.Describe());
}
```

- Třídy a funkce implementujte postupně, `throw new NotImplementedException()` pomůže.
- Kousky testovacího kódu si zakomentujte pro vývoj.

##### Number

Jako další část implementujte třídu `Number`, která je trochu divná variace na číselné operace:

- `a + b` slepí čísla za sebe, tedy `12 + 34` je `1234`
- `-a` otočí cifry v čísle, tedy -`123` je `321`
- `a * n` kde n je typu `int` nakopíruje číslo `a` n-krát, tedy `123 * 2` je `123123`

Jako kostra Vám poslouží:

```c#
class Number
{
    public Number(string value = "")
    {
    }

    public Number(long value)
    {
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    public static Number operator +(Number a, Number b)
    {
        throw new NotImplementedException();
    }

    public static Number operator -(Number a)
    {
        throw new NotImplementedException();
    }

    public static Number operator *(Number a, int times)
    {
        throw new NotImplementedException();
    }

    public static implicit operator long(Number v)
    {
        throw new NotImplementedException();
    }
}
```

a jako testovací kód poslouží:

```c#
/* 4) play with Number class */
Console.WriteLine("A play with Numbers:");

var number = new Number(1) + new Number(234);
Console.WriteLine(number);
number *= 1;
number = number * 3;
Console.WriteLine(number);
number = -number;
Console.WriteLine(number);

long intNumber = number;
Debug.Assert(intNumber == 432143214321);
var number2 = new Number(intNumber);
```

**Ukázku řešení naleznete [zde](examples/practice3)**.

### 11.3.2022 (4. cvičení)

#### Úlohy k procvičování

Za domácí úkol jste řešili Recodex úlohu **Dumbo Octopus** a zkusíte si na cizím kódu
udělat následující úkoly.

Tip: Vstup na čtení si lze uložit do souboru a pak číst standartní vstup z něj:
```
dotnet run < input.txt
```

a nebo případně na Windows s PowerShell:
```
cat input.txt | dotnet run
```

Pokud chcete ve VSCODE debugovat s přesměrovaným vstupem, je třeba si dát zpět:
`"console":"internalConsole"` v `launch.json`souboru a pak postupovat dle:
https://code.visualstudio.com/docs/editor/debugging#_redirect-inputoutput-tofrom-the-debug-target

**Programy pro úkoly**:
* [Program #1](practice4/Program1.cs)
* [Program #2](practice4/Program2.cs)
* [Program #3](practice4/Program3.cs)
* [Program #4](practice4/Program4.cs)

##### Úkol #1:

Proveďte simulaci chobotnic, avšak místo původních 100 kroků simulujte do té doby, než
se v jednom kole rozsvítí všechny chotobnice.

Například pro vstup:
```
10
5483143223
2745854711
5264556173
6141336146
6357385478
4167524645
2176841721
6882881134
4846848554
5283751526
```

Bude výstup:
```
195
```

Tedy v 195. kroce všechny chotobnice blikly.

##### Úkol #2:

Rozšiřte původní algoritmus na 100 kroků tak, aby při bliknutí chobotnice se zvýšila hodnota
chobotnicím ve vzdálenosti **2** a to i přes úhlopříčku. V původním zadání to
bylo ve vzdálenosti **1**.

Například pro vstup:
```
5483143223
2745854711
5264556173
6141336146
6357385478
4167524645
2176841721
6882881134
4846848554
5283751526
```

Bude výstup:
```
1000
```

a nebo pro:
```
5
11111
19991
19191
19991
11111
```

Bude výstup:
```
259
```

##### Úkol #3:

Zkuste si prostudovat zdrojové kódy spolužáků a zkuste se zamyslet nad následujícími vlastnostmi:

  - logické členění programu (třídy, metody/funkce, proměnné, parametry, apod.)
  - volby jmen identifikátorů
  - jak se dobře kód čte a chápe (málo nebo moc komentářů)
  - jak se kód bude dobře rozšiřovat, udržovat, debugovat
  - jaké jsou použity datové struktury, případně jak jsou vhodné
  - coding style (indentace, konzistence stylu, zkrátka vizuální stránka věci)
  - má program nějaké ladící výpisy, které mohou pomoct s hledáním problémů
  - jak dobře by šlo testovat jednotlivé části algoritmu
  - zkuste seřadit Program #1-4 od nejlepšího řešení, po ta horší

### 18.3.2022 (5. cvičení)

- Kategorie základních typů na hodnotové a referenční.
- Diskuze ohledně parametrů a klíčových slov `ref`, `in`, `out`

#### Úlohy k procvičování

- **Smažte si v `.csproj`: `<Nullable>enable</Nullable>`**.

- Napište funkci `Add5`, která bude mít návratovou hodnotu `void` a přičte k parametru
  hodnotu 5. Otestujte jak se chovají `ref`, `in` a `out` modifikátory u parametru.
- Napište obdobnou funkci pro `string`, která se bude jmenovat `AppendDot`, která ke stringu
  přilepí tečku.
- Otestujte si to pomocí funkce `Debug.Assert` z namespace `System.Diagnostics`.
- Obdobně napište malé testy na 2 funkce:

```c#
    static void Update(List<int> list)
    {
        list = new List<int>() { 4, 5, 6 };
    }

    static void UpdateRef(ref List<int> list)
    {
        list = new List<int>() { 4, 5, 6 };
    }
```

a koukněte jak se chovají.

-  Vytvořte si 2 instance `int[]` (třeba `array1` a `array2`) a vyzkoušejte jak se chová funkce `array1.CopyTo(array2, 0)`,
   jak se to chová pokud zvolíte nenulový druhý parametr?
- Napište funkci `PrintArray(in int[] array)`, která do konzole vytiskne na jeden řádek hodnoty pole a nějak je oddělí
- Obdobně napište funkci `PrintArrays(in int[][] arrays)`, která na jeden řádek vytiskne pole polí a navíc bude volat předchozí funkci.

- Zkuste se v debugeru podívat na to, jak se bude chovat následující kód:

```c#
int[] array = new int[] { 100, 200, 300 };
int[][] arrays1 = new int[][] { new int[] {1, 2}, array };
int[][] arrays2 = new int[][] { array, new int[] { 3 ,4} };

array[0] = -1;
arrays2.CopyTo(arrays1, 2);
```

**Ukázku řešení naleznete [zde](examples/reference-vs-value)**.

### 25.3.2022 (6. cvičení)

#### 1. část

- Pro následující úkoly zkuste co nejvíce použít Debugger (F5) a dívat se na **warning**y
  překladače.

- Implementujte jednoduchou třídu `Line`, která bude mít následující konstruktor:
  `public Line(int width, string color)`.
- Implementujte `ToString`, aby šla používat pro ladící výpisy.
- O dvou přímkách řekneme, že jsou stejné, pokud mají stejnou `width` a `color`. Pokud jsou
  obě nulové šířky, pak na barvě nesejde. Pokud chceme porovnat dvě přímky, tak nejprve řadíme
  podle `width` a případně pak podle `color`.

- Vyzkoušejte, jak se řadí objekty:

```
var a = new Line(5, "red");
var b = new Line(1, "blue");
object[] items = new object[] { new Line(0, "green"), a, b, a };
Array.Sort(items);
```

- Implementujte `IComparable` interface pro třídu `Line` a jak se to chová teďka?
- Pomocí toho nyný můžete implementovat `public static bool operator==(Line a, Line b)`, tak aby procházelo:
`Debug.Assert(new Line(0, "red") == new Line(0, "blue"));`

- Nyní naimplementujte aby šlo porovnávat dvě přímky pomocí `<`, tedy `Debug.Assert(line1 < line2)`, napište
  si na to malý test.

- Porovnejte jaký je rozdíl mezi `object.ReferenceEquals` a `object.Equals` pro naši třídu `Line`.

#### 2. část

- Vytvořte novou solution, kde vytvoříte knihovnu (ta bude obsahovat třídu `Line`) a jako druhý projekt si vytvořte
  `nUnit` testovací projekt.

- Návody pro [Visual Studio naleznete zde](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2022)
  a pro [VS Code zde](https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0).
  Dále pro VS Code budete potřebovat `.NET Core Test Extension`, které pak umí testy spouštět.

- Vyzkoušejte si základní `[Test]` a `[TestCase]` atributy pro testovací funkce a také si vyzkoušejte co nabízí za nové funkce
 [třída `Assert`](https://docs.microsoft.com/en-us/dotnet/api/nunit.framework.assert).

- Testy lze pak pustit ve VSCode pomocí `dotnet test` a nebo pomocí Testing v VSCode, kde lze testy procházet a pouštět.

**Ukázku řešení naleznete [zde](examples/solution-with-tests)**.

### 1.4.2022 (7. cvičení)

#### Dynamické programování

Budeme řešit následující problémy:

- **Fibonacciho posloupnout** - fib(1) = 1, fib(2) = 1 a každé další číslo je součtem dvou předchozích
- **GridTraveler** - máme tabulku velikosti `m x n` a ptáme se kolika způsoby lze projít z levého
  horního rohu do pravého dolního tak, že se smíme pohybovat pouze dolů a doprava.
  Funkce `int GridTraveler(int m, int n)` vrátí počet takových cest.
- **CanSum** (možný součet) - napište funkci `bool CanSum(int sum, int[] values)`, která vrátí true
  právě když lze z nezáporých čísel (`values`) udělat soušet `sum`. Každé číslo lze použít **opakovaně**.
- **HowSum** (jak sečít) - obdobně jako minulý bod, akorát nás zajímá jak vypadají ty jednotlivé sčítance.
  `int[] HowSum(int sum, int[] values)`.
- **BestSum** (nejkratší součet) - obdobně jako v minulém bodě, ale je nám vráceno nejkratší možné pole.


**Ukázku řešení naleznete [zde](examples/dynamic-programming)**.

Dále se můžete podívat na [skvělé video](https://www.youtube.com/watch?v=oBt53YbR9Kk),
které se věnuje dymickému programování a zde kterého jsme dnes řešili úlohy.

### 8.4.2022 (8. cvičení)

##### Diskrétní simulace Pošty

Úkolem je napsat simulaci pošty, která bude **řízená událostmi** a jejich zpracováním.
Pošta je pro jednoduchost otevřená a nastanou 3 základní události:
- každých **5 jednotek času** (nemusíme si lámat hlavu s hodinami, minutami, apod.) přijde
  nový zákazník
- obsloužení zákazníka bude trvat **6 jednotek času**
- pošta je na vesnici a proto má právě **jednu přepážku**
- pošta zavře po **100 jednotkách** času a poté už neotevře, simulace tím skončí
- poslední zákazník, jehož obsluha začne do zavírací doby se stihne obsloužit

**Úkoly**:

1. Navrhněte základní třídy a objekty, které budeme pro simulaci potřebovat a načrtněte vztahy mezi nima.
2. Navrhněte jaké budeme potřebovat události a co tak asi bude dělat a volat obsluha každé z nich.
3. Jak se vypořádáme s tím, že nastanou 2 a více událostí ve stejný čas?
4. Jaké věci se nám budou hodit pro ladění a testování, zda simulace funguje?
5. Zkuste udělat co nejlepší zapouzdření dat.
6. Implementujte základní verzi simulace.

**Pokročilé úkoly**:

1. Vyzkoušejte jak odlišit výpisy do konzole dle barvy (např. `Console.ForegroundColor = ConsoleColor.Cyan`)
2. Zkuste, aby se zákazníci objevovali trochu náhodně (1-5 minut) a jejich obsluha byla také variabilní (2-6 minut),
   použijte `Random`.
3. Implementujte další událost (**otevření pošty**), která nastane po **200 jednotkách** času od zavření.
