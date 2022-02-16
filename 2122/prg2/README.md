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

1. Napiště program, který se optá a jméno a pak ho osloví: např. `Hello Martin`.
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
   `mezera` a nebo `tečka`.
1. Pro dané číslo vypište text `dělitelné třemi`, `dělitelné sedmi` nebo `dělitelné deseti` pokud dané číslo
   splňuje danou dělitelnost.

##### Funkce

1. Napište funkci, která vrací minimum ze svých třech celočíselných argumentů.
1. Napište funkci `Compare`, která dostane dvě čísla a, b a vrací 1 pro a > b, 0 pro a == b a -1 pro a < b.
   Místo 1 a -1 se dají použít libovolná kladná a záporná čísla. To je standardní způsob, jak se v C# udává výsledek porovnání.
1. Napište funkci `IsPositive(n)`, která přijme celé číslo jako argument a vrací true, je-li číslo nezáporné.
1. Nyní napište funkci `IsNegativeOrZeno(n)`, která vrací true, není-li n kladné. Využijte funkci z předešlého bodu.
1. Napište funkci, která počítá ciferný součet čísla.
