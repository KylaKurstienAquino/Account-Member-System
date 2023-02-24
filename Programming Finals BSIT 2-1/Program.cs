using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
internal class Information
{
    public string UserName { get; set; }
    public string PassWord { get; set; }

}
internal class Guild
{
    public string number;
    public string gname;
}
internal class MemInfo
{
    public string affi { get; set; }
    public string name { get; set; }
    public string nn { get; set; }
    public int age { get; set; }
    public string gen { get; set; }
    public string bday { get; set; }
    public string abi { get; set; }
    public string rank { get; set; }
    public string pos { get; set; }
    public string stat { get; set; }

}
internal class Restats
{
    public string snum;
    public string sstats;

}
internal class Acqu
{
    public string add { get; set; }
    public string ser { get; set; }
    public string status { get; set; }
    public string type { get; set; }
    public string tname { get; set; }
    public string namenum { get; set; }
}
internal class ConCha
{
    public int yr;
    public int mnt;
    public int coins;
    public int gold;
    public int rmoney;
}
internal class Misn
{
    public string getdai;
    public string getin;
    public string getach;
}
internal class Call
{
    public string call1;
    public string call2;
    public string call3;
    public string endcall;
}
class Program
{
    static List<Information> systemAccount = new();
    static List<MemInfo> members = new();
    static List<Guild> guilds = new();
    static List<Restats> ship = new();
    static List<Acqu> afu = new();
    static List<ConCha> m = new();
    static List<Call> Cal = new();
    static List<Acqu> Iafu = new();
    static List<Acqu> Aafu = new();
    static List<Acqu> Zafu = new();
    static List<Misn> gtas = new();
    static List<string> ICLog = new();
    static List<string> ACLog = new();
    static List<string> ZCLog = new();
    static string otp = "(On the phone)";
    static string[] anrk = { "A", "B", "C", "D", "E", "F", "S" };
    static string[] tion = { "offense", "defense", "support" };
    static string turn, gg, cico, con;
    static int months, ths, gds, mntcomp, mos, quotg, modc, diff, prod, dgold, dcoins, ctg, lom, gtc, sum, adc;
    static string d1, d2, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, h, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15;
    static void Main(string[] args)
    {
        //items for Tasks
        d1 = "Warm Up - Kill 10 Diurnal beasts";
        d2 = "Cool Down - Kill 10 Nocturnal beasts";
        i1 = "Kill 100 Gigas FirAnts = ";
        i2 = "Explore the Deep = ";
        i3 = "Explore the Forest of Garteol = ";
        i4 = "Explore the Sea of Souls = ";
        i5 = "Get out of the Sea of Souls";
        i6 = "Hunt the wandering ghoul";
        i7 = "Enter the Upside Village of the Heulm";
        i8 = "Find the entrance of the Villan Cave";
        i9 = "Destroy the Great Wall of Guillont";
        i10 = "Defeat the Terror of the Eyestorm Vult";
        h = "Assemble - Meet the other protagonists";
        a1 = "Gigas BumBees Hunter -Killed 100+ Gigas Bumbees";
        a2 = "Repercuss Bitan Hunter -Killed 100+ Repercuss Bitan";
        a3 = "Nocturnal Hunter - Killed 100 + beasts of the night";
        a4 = "Diurnal Hunter - Killed 100+ beasts of the day";
        a5 = "Social Pupa - Befriended 10+ people";
        a6 = "Social Caterpillar - Befriended 50+ people";
        a7 = "Social Butterfly - Befriended 100+ people";
        a8 = "Dungeon Raider - Raided 10+ dungeons";
        a9 = "Champion - become a holder of one or more of the Sacred Weapon";
        a10 = "Bearer - become a holder of one or more of the Sacred Items";
        a11 = "Defender of the North - Defeated the king of Ice Tiger";
        a12 = "Defender of the South - Defeated the queen of Earth Tortoise";
        a13 = "Defender of the East - Defeated the king of Wind Dragon";
        a14 = "Defender of the West - Defeated the queen of the Fire Phoenix";
        a15 = "Protector of the Gate - prevented the beasts from escaping the gate";

        //Accounts of the users
        Information acc1 = new();
        acc1.UserName = "Imera#0130";
        acc1.PassWord = "IAmRebellion";
        systemAccount.Add(acc1);

        Information acc2 = new();
        acc2.UserName = "Alvin#0312";
        acc2.PassWord = "letmerest";
        systemAccount.Add(acc2);

        Information acc3 = new();
        acc3.UserName = "Zachary#0829";
        acc3.PassWord = "KOGF";
        systemAccount.Add(acc3);

        Information acc4 = new();
        systemAccount.Add(acc4);

        //Information of the users
        MemInfo Imera = new();
        Imera.affi = "Unlock Guild";
        Imera.name = "Imera";
        Imera.nn = "Ime";
        Imera.age = 15;
        Imera.gen = "Female";
        Imera.bday = "01-30";
        Imera.abi = "Bind";
        Imera.rank = "B";
        Imera.pos = "Support";
        Imera.stat = "Hungry";
        members.Add(Imera);

        MemInfo Alvin = new();
        Alvin.affi = "Sun's Grace Home";
        Alvin.name = "Alvin";
        Alvin.nn = "Vin";
        Alvin.age = 17;
        Alvin.gen = "Male";
        Alvin.bday = "03-12";
        Alvin.abi = "Claircognizance";
        Alvin.rank = "S";
        Alvin.pos = "Support";
        Alvin.stat = "Waiting";
        members.Add(Alvin);

        MemInfo Zachary = new();
        Zachary.affi = "Knights of the Golden Flame";
        Zachary.name = "Zachary";
        Zachary.nn = "Zac";
        Zachary.age = 17;
        Zachary.gen = "Male";
        Zachary.bday = "08-29";
        Zachary.abi = "Fire Embodiment";
        Zachary.rank = "S";
        Zachary.pos = "Offense";
        Zachary.stat = "Single";
        members.Add(Zachary);

        MemInfo NewMem = new();
        members.Add(NewMem);

        //user status
        Restats sing = new();
        sing.snum = "1";
        sing.sstats = "Single";
        ship.Add(sing);

        Restats take = new();
        take.snum = "2";
        take.sstats = "Taken";
        ship.Add(take);

        Restats compli = new();
        compli.snum = "3";
        compli.sstats = "Complicated";
        ship.Add(compli);

        Restats oth = new();
        oth.snum = "4";
        ship.Add(oth);

        //contact details of the user
        Acqu ImeraAqu = new();
        ImeraAqu.tname = "Imera";
        ImeraAqu.add = "gYXBcIJ0nM";
        ImeraAqu.ser = "On";
        ImeraAqu.status = "Active";
        afu.Add(ImeraAqu);

        Acqu AlvinAqu = new();
        AlvinAqu.tname = "Alvin";
        AlvinAqu.add = "yycxuU0O5L";
        AlvinAqu.ser = "Busy";
        AlvinAqu.status = "Active";
        afu.Add(AlvinAqu);

        Acqu ZacharyAqu = new();
        ZacharyAqu.tname = "Zachary";
        ZacharyAqu.add = "LrIf7wqCDq";
        ZacharyAqu.ser = "On";
        ZacharyAqu.status = "Active";
        afu.Add(ZacharyAqu);

        Acqu NewMemAqu = new();
        NewMemAqu.status = "Active";
        afu.Add(NewMemAqu);

        Random dom = new Random();
        string b = "abcdefghijklmnopqrstuvwxyz0123456789";
        int length = 10;
        string rd = "";
        for (int i = 0; i < length; i++)
        {
            int a = dom.Next(b.Length);
            rd = rd + b.ElementAt(a);
        }
        NewMemAqu.add = rd;

        //finances of the users
        ConCha ImeCos = new();
        ImeCos.yr = 2;
        ImeCos.mnt = 9;
        ImeCos.coins = 17650;
        ImeCos.gold = 15;
        ImeCos.rmoney = 130;
        m.Add(ImeCos);

        ConCha AlvCos = new();
        AlvCos.yr = 5;
        AlvCos.mnt = 10;
        AlvCos.coins = 1561650;
        AlvCos.gold = 105;
        AlvCos.rmoney = 13400;
        m.Add(AlvCos);

        ConCha ZacCos = new();
        ZacCos.yr = 3;
        ZacCos.mnt = 11;
        ZacCos.coins = 1872650;
        ZacCos.gold = 256;
        ZacCos.rmoney = 210406;
        m.Add(ZacCos);

        ConCha NewCos = new();
        NewCos.yr = 1;
        NewCos.mnt = 0;
        NewCos.coins = 0;
        NewCos.gold = 0;
        NewCos.rmoney = 0;
        m.Add(NewCos);

        //users Tasks infos.
        Misn ImeTas = new();
        ImeTas.getdai = d2;
        ImeTas.getin = i1 + "78/100\n" + i2 + "43%\n" + i8 + "\n";
        ImeTas.getach = a1 + " (Killed - 867)\n" + a2 + " (Killed - 673)\n" + a3 + " (Killed - 12027)\n" + a4 + " (Killed - 13617)\n" + a5 + " (Friends = 28)\n" + a8 + "(Raided = 32)\n" + a11 + "\n" + a15;
        gtas.Add(ImeTas);

        Misn AlvTas = new();
        AlvTas.getdai = d1 + "\n" + d2;
        AlvTas.getin = i4 + "86%\n" + i5 + "\n" + i6;
        AlvTas.getach = a1 + " (Killed - 231092)\n" + a2 + " (Killed - 327801)\n" + a3 + " (Killed - 1093423)\n" + a4 + " (Killed - 1104345)\n" + a6 + " (Friends = 78)\n" + a8 + "(Raided = 197)\n" + a9 + "\n" + a10 + "\n" + a12 + "\n" + a13 + "\n" + a15;
        gtas.Add(AlvTas);

        Misn ZacTas = new();
        ZacTas.getdai = d2;
        ZacTas.getin = i3 + "58%\n" + i7 + "\n" + i9 + "\n" + i10;
        ZacTas.getach = a1 + " (Killed - 34364)\n" + a2 + " (Killed - 462642)\n" + a3 + " (Killed - 283243)\n" + a4 + " (Killed - 214251)\n" + a5 + " (Friends = 28)\n" + a8 + "(Raided = 98)\n" + a11 + "\n" + a14 + "\n" + a15;
        gtas.Add(ZacTas);

        Misn NewTas = new();
        NewTas.getdai = d1 + "\n" + d2;
        NewTas.getin = "None";
        NewTas.getach = "None";

        //call log of the users
        ICLog.Add("Incoming - Fillarie");
        ICLog.Add("Incoming - Alleia");
        ICLog.Add("Outgoing - Jyson");
        ICLog.Add("Incoming - Ellesrie");
        ICLog.Add("Outgoing - Reidyn");
        ICLog.Add("Outgoing - Carielle");

        ACLog.Add("Incoming - Zhaila");
        ACLog.Add("Outgoing - Devana");
        ACLog.Add("Outgoing - Jane");
        ACLog.Add("Incoming - Zhaila");

        ZCLog.Add("Incoming - Aranela");
        ZCLog.Add("Incoming - Lillian");
        ZCLog.Add("Outgoing - Hannah");

        //the users friends contact details
        Acqu Alleia = new();
        Alleia.namenum = "1";
        Alleia.tname = "Alleia    ";
        Alleia.add = "EZmNNMDFAK";
        Alleia.ser = "Busy     ";
        Alleia.status = "Active";
        Iafu.Add(Alleia);

        Acqu Fillarie = new();
        Fillarie.namenum = "2";
        Fillarie.tname = "Fillarie  ";
        Fillarie.add = "kseMoljdW8";
        Fillarie.ser = "On       ";
        Fillarie.status = "Active";
        Iafu.Add(Fillarie);

        Acqu Dylan = new();
        Dylan.namenum = "3";
        Dylan.tname = "Dylan     ";
        Dylan.add = "jcKsShxDxo";
        Dylan.ser = "On       ";
        Dylan.status = "Active";
        Iafu.Add(Dylan);

        Acqu Ellesrie = new();
        Ellesrie.namenum = "4";
        Ellesrie.tname = "Ellesrie  ";
        Ellesrie.add = "Q0LFEIrCvW";
        Ellesrie.ser = "Busy     ";
        Ellesrie.status = "Active";
        Iafu.Add(Ellesrie);

        Acqu Reidyn = new();
        Reidyn.namenum = "5";
        Reidyn.tname = "Reidyn    ";
        Reidyn.add = "wggCVSdqmX";
        Reidyn.ser = "Busy     ";
        Reidyn.status = "Active";
        Iafu.Add(Reidyn);

        Acqu Nelson = new();
        Nelson.namenum = "6";
        Nelson.tname = "Nelson    ";
        Nelson.add = "NMawKCSUeY";
        Nelson.ser = "Busy     ";
        Nelson.status = "Active";
        Iafu.Add(Nelson);

        Acqu Carielle = new();
        Carielle.namenum = "7";
        Carielle.tname = "Carielle  ";
        Carielle.add = "Hjbfalkhf2r1";
        Carielle.ser = "Busy     ";
        Carielle.status = "Active";
        Iafu.Add(Carielle);

        Acqu Jyson = new();
        Jyson.namenum = "8";
        Jyson.tname = "Jyson     ";
        Jyson.add = "SXQZ7814Gr";
        Jyson.ser = "Off      ";
        Jyson.status = "Active";
        Iafu.Add(Jyson);

        Acqu Jane = new();
        Jane.namenum = "1";
        Jane.tname = "Jane      ";
        Jane.add = "bW5cZX9UPD";
        Jane.ser = "Busy     ";
        Jane.status = "Active";
        Aafu.Add(Jane);

        Acqu Zhaila = new();
        Zhaila.namenum = "2";
        Zhaila.tname = "Zhaila    ";
        Zhaila.add = "OydG3ShER8";
        Zhaila.ser = "On       ";
        Zhaila.status = "Active";
        Aafu.Add(Zhaila);

        Acqu Nia = new();
        Nia.namenum = "3";
        Nia.tname = "Nia       ";
        Nia.add = "ujacev46I1";
        Nia.ser = "On       ";
        Nia.status = "Active";
        Aafu.Add(Nia);

        Acqu Hector = new();
        Hector.namenum = "4";
        Hector.tname = "Hector    ";
        Hector.add = "LGTHebZPwj";
        Hector.ser = "Off      ";
        Hector.status = "Active";
        Aafu.Add(Hector);

        Acqu Ronnie = new();
        Ronnie.namenum = "5";
        Ronnie.tname = "Ronnie    ";
        Ronnie.add = "YJlsfT8sva";
        Ronnie.ser = "Busy     ";
        Ronnie.status = "Active";
        Aafu.Add(Ronnie);

        Acqu Jary = new();
        Jary.namenum = "6";
        Jary.tname = "Jary      ";
        Jary.add = "jcKsShxDxo";
        Jary.ser = "Busy     ";
        Jary.status = "Active";
        Aafu.Add(Dylan);

        Acqu Lillian = new();
        Lillian.namenum = "1";
        Lillian.tname = "Lillian   ";
        Lillian.add = "f7RKoVu80n";
        Lillian.ser = "On       ";
        Lillian.status = "Active";
        Zafu.Add(Lillian);

        Acqu Annalyn = new();
        Annalyn.namenum = "2";
        Annalyn.tname = "Annalyn   ";
        Annalyn.add = "Zg5ydlAxDr";
        Annalyn.ser = "Busy     ";
        Annalyn.status = "Active";
        Zafu.Add(Annalyn);

        Acqu Aranela = new();
        Aranela.namenum = "3";
        Aranela.tname = "Aranela   ";
        Aranela.add = "8OvA4xCAP3";
        Aranela.ser = "On       ";
        Aranela.status = "Active";
        Zafu.Add(Aranela);

        Acqu Carter = new();
        Carter.namenum = "4";
        Carter.tname = "Carter    ";
        Carter.add = "DvzQWbxOE4";
        Carter.ser = "Off      ";
        Carter.status = "Active";
        Zafu.Add(Carter);

        Acqu Hannah = new();
        Hannah.namenum = "5";
        Hannah.tname = "Hannah    ";
        Hannah.add = "6H8gBRUJ3z";
        Hannah.ser = "Busy     ";
        Hannah.status = "Active";
        Zafu.Add(Hannah);

        Acqu Devana = new();
        Devana.namenum = "6";
        Devana.tname = "Devana    ";
        Devana.add = "yjkHA5qO7c";
        Devana.ser = "Busy     ";
        Devana.status = "Active";
        Zafu.Add(Devana);

        //calling the users friend
        Call CFillarie = new();
        CFillarie.call1 = "Hello? Imera?";
        CFillarie.call2 = "AH! Wait a second. ALLEIA!";
        CFillarie.call3 = "Sorry, hold on. ALLEIA! COME BACK HERE! YOU CAN'T DESTROY THAT! THAT'S - -";
        CFillarie.endcall = "Oh God. Sorry call you later. ALLEIA RUN!!! THE GIGAS BUMBEES ARE AFTER YOU!! TO THE WATER---";
        Cal.Add(CFillarie);

        Call CZhaila = new();
        CZhaila.call1 = "Hello-hello?";
        CZhaila.call2 = " 'Zhai, go greet your cousins on the second deck.' Alright, I'll go later. Ah sorry what?";
        CZhaila.call3 = " 'And greet your aunts and uncles on the third deck.' I'll do it later, okay?! I'm sorry, come again?";
        CZhaila.endcall = " 'Oh! right, I heard your uncle Zen is back, go greet him to.' Wai- Huh? Wait what? REALLY? Ah, sorry, I'm at the reunion right now. Oh! but I'll call you later okay, sorry mister Alvin.";
        Cal.Add(CZhaila);

        Call CNia = new();
        CNia.call1 = "Hello? Vin?";
        CNia.call2 = "Ah madam Miranda, I already took the clothes inside don't worry. Oh hello, sorry madam Mira called me, what again? ";
        CNia.call3 = "Wait excuse me. RONNIE! HEY! MADAM SAVANNAH WAS LOOKING FOR YOU TO CLEAN UP THE CABIN! RUN BEFORE SHE KILLS YOU WITH THE BROOM! Sorry, Ronnie just got out from his room with his messy hair so I just had to- - what's your saying again?";
        CNia.endcall = "Hold on. Ah! Sorry again, I have to help Madam Cora on the kitchen. Talk to you later. ";
        Cal.Add(CNia);

        Call CDylan = new();
        CDylan.call1 = "Alright~ I admit it, it's me. It's my fault. I'm sorry. Just... calm down first, okay?. Breathe in~... Breathe out~... I know you're angry. I know. But I didn't mean to break your UI Wristlet. ";
        CDylan.call2 = "I'm sorry. Really. I do. Once we're back, I'll treat you to something nice for compensation. How's that?";
        CDylan.call3 = "'Dylan! It's here!' Oh! It's seems Reidyn found the nest of the Repercuss Bitan. Gotta go, ciao~";
        CDylan.endcall = "...'thank you Dylan' F*ck you, Fynn---";
        Cal.Add(CDylan);

        Call CLillian = new();
        CLillian.call1 = "Oh! ah u-uhm, e-ehem Hel-llo Leader.Ho-how are you? I li- I like your weather today hehe.";
        CLillian.call2 = "NO! I-I mean I like the weather today not you.";
        CLillian.call3 = "NO WAIT! THAT'S NOT WHAT I- WHAT I MEAN IS- IT-IT'S NOT THAT I HATE YOU. I-I just don't like you. But I LIKE YOU. B-but it's not that I like you. I DON'T HATE YOU BUT I DON'T LIKE YOU. Y-You know what I mean?.";
        CLillian.endcall = ". . . PLEASEDON'TCALLMEAGAIN!!!";
        Cal.Add(CLillian);

        Call CAranela = new();
        CAranela.call1 = "LEAD! Oh Gawd, Nice timing! Can you please come back quick and stop Hanna- WAIT STOP IT HANNAH THAT'S - -.";
        CAranela.call2 = "I.Told.Ya. That is the wrong Formula! It.was.supposed.to be Taur Candlehorn first then- WAIT!! NOT THE LAUFLEGE LEG - - ";
        CAranela.call3 = ". . .";
        CAranela.endcall = "... Imma kill ya---";
        Cal.Add(CAranela);

        do
        {
            Console.WriteLine("Try: ");
            Console.WriteLine(acc1.UserName + " " + acc1.PassWord);
            Console.WriteLine(acc2.UserName + " " + acc2.PassWord);
            Console.WriteLine(acc3.UserName + " " + acc3.PassWord);
            //showing the Welcome Method
            string input = Welcome();
            switch (input)
            {
                case "1":
                    string pass;
                    string email;
                    string main;
                    Console.WriteLine("===LOG IN===");
                    Console.WriteLine("Email: ");
                    email = Console.ReadLine();

                    //Reading the input to determine the user
                    if (email.Equals(acc1.UserName))
                    {
                        pass = Password();

                        if (pass.Equals(acc1.PassWord))
                        {
                            do
                            { //show MainMenu method
                                main = MainMenu();

                                switch (main)
                                {
                                    case "1":
                                        //users infos. display
                                        PlayerInfo(Imera);
                                        BackToMenu();
                                        break;
                                    case "2":
                                        //users tasks display
                                        GetTasks();
                                        do
                                        {
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine();
                                            if (turn == "1")
                                            {
                                                GetMissions(ImeTas);

                                                Console.WriteLine("-Hidden Mission= (Failure of keeping this mission hidden may result on death)");
                                                Console.WriteLine(h);
                                            }
                                            else if (turn == "2")
                                            {
                                                GetAchives(ImeTas);
                                            }
                                        }
                                        while (turn != "0");
                                        break;

                                    case "3":
                                        //users contacts display
                                        GetAcq(ImeraAqu);
                                        do
                                        {

                                            Friends(Alleia);
                                            Friends(Fillarie);
                                            Friends(Dylan);
                                            Friends(Ellesrie);
                                            Friends(Reidyn);
                                            Friends(Nelson);
                                            Friends(Carielle);
                                            Friends(Jyson);
                                            Console.WriteLine("\nC - Call");
                                            Console.WriteLine("0 - return");
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "C":
                                                    Console.WriteLine("\nWho do you want to call?");
                                                    ImeraCon();
                                                    Console.WriteLine("\nContact = ");
                                                    con = Console.ReadLine();
                                                    var tact = Iafu.Find(x => x.namenum == con).ser;
                                                    var recname = Iafu.Find(x => x.namenum == con).tname;
                                                    if (tact == "Off      " || tact == "Busy     ")
                                                    {
                                                        Console.WriteLine("\nCalling. . .");
                                                        Thread.Sleep(3000);
                                                        Console.WriteLine("The service you contacted is either busy or off. Please try again later.\n");
                                                        ICLog.Add("Outgoing - " + recname);
                                                    }
                                                    else
                                                    {
                                                        //calling if not "busy" and converting it to "Busy"
                                                        if (con == "2")
                                                        {
                                                            CalRem(ImeraAqu, Fillarie, CFillarie);
                                                            Fillarie.ser = "Busy     ";
                                                            ICLog.Add("Outgoing - " + recname);
                                                        }
                                                        else if (con == "3")
                                                        {
                                                            CalRem(ImeraAqu, Dylan, CDylan);
                                                            Dylan.ser = "Busy     ";
                                                            ICLog.Add("Outgoing - " + recname);
                                                        }
                                                    }
                                                    break;
                                                default: break;
                                            }


                                        } while (turn != "0");
                                        break;

                                    case "4":
                                        //displaying the users call history
                                        GetICalllog();
                                        BackToMenu();
                                        break;

                                    case "5":
                                        //computing the users finance and contract
                                        Console.WriteLine("\nFINANCE AND CONTRACT\n");
                                        do
                                        {
                                            Renew(ImeCos);
                                            FiCon();
                                            Console.WriteLine("Enter here:");

                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "1":
                                                    Console.WriteLine("\nMoney Conversion");
                                                    Console.WriteLine("1 - Coins to Gold: 1000 Coins = 1 Gold");
                                                    Console.WriteLine("2 - Gold to Coins: 1 Gold = 1000 Coins");
                                                    Console.WriteLine("3 - Cash to Gold: 1 Cash = 50 Golds");
                                                    Console.WriteLine("4 - Gold to Cash: 50 Golds = 1 Cash");
                                                    Console.WriteLine("Enter here: ");
                                                    gg = Console.ReadLine();

                                                    switch (gg)
                                                    {
                                                        case "1":

                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dcoins = Convert.ToInt32(Console.ReadLine());

                                                            if (dcoins > ImeCos.coins) { Console.WriteLine("You don't have enough coins"); }

                                                            else if (dcoins < 1000)
                                                            {
                                                                Console.WriteLine("Cannot be converted");
                                                            }
                                                            else
                                                            {
                                                                ctg = dcoins / 1000;
                                                                lom = dcoins % 1000;
                                                                diff = ImeCos.coins - dcoins;
                                                                ImeCos.gold = ImeCos.gold + ctg;
                                                                ImeCos.coins = diff + lom;
                                                            }

                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dgold = Convert.ToInt32(Console.ReadLine());

                                                            if (dgold > ImeCos.gold)
                                                            {
                                                                Console.WriteLine("You don't have enough gold");
                                                            }

                                                            else
                                                            {
                                                                gtc = dgold * 1000;
                                                                diff = ImeCos.gold - dgold;
                                                                ImeCos.coins = ImeCos.coins + gtc;
                                                                ImeCos.gold = diff;
                                                            }

                                                            break;

                                                        case "3":
                                                            Console.WriteLine("\nHow much cash you wish to convert to gold?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            sum = prod * 50;
                                                            ImeCos.gold = ImeCos.gold + sum;
                                                            ImeCos.rmoney = ImeCos.rmoney - prod;

                                                            break;

                                                        case "4":
                                                            Console.WriteLine("\nHow much gold you wish to convert to cash?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            if (prod < 50)
                                                            {
                                                                Console.WriteLine("Insufficient gold/s");
                                                            }
                                                            else
                                                            {
                                                                sum = prod / 50;
                                                                ImeCos.rmoney = ImeCos.rmoney + sum;
                                                                ImeCos.gold = ImeCos.gold - prod;
                                                            }

                                                            break;

                                                        default: break;
                                                    }

                                                    break;

                                                case "2":

                                                    Console.WriteLine("\nHow much time do you wish to extend?");
                                                    Console.WriteLine("1 month = 500 coins");
                                                    Console.WriteLine("3 months = 1 gold and 500 coins / 1500 coins");
                                                    Console.WriteLine("6 months = 3 golds / 3000 coins");
                                                    Console.WriteLine("How many month/s? ");
                                                    mos = Convert.ToInt32(Console.ReadLine());

                                                    months = mos + ImeCos.mnt;
                                                    mntcomp = mos * 500;
                                                    quotg = mntcomp / 1000;
                                                    modc = mntcomp % 1000;
                                                    ths = months / 12;
                                                    gds = months % 12;

                                                    if (months >= 12)
                                                    {
                                                        if (mntcomp > ImeCos.coins)
                                                        {
                                                            if (quotg > ImeCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else
                                                            {
                                                                ImeCos.gold = ImeCos.gold - quotg;
                                                                ImeCos.coins = ImeCos.coins - modc;
                                                                ImeCos.yr = ImeCos.yr + ths;
                                                                ImeCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < ImeCos.coins)
                                                        {
                                                            ImeCos.coins = ImeCos.coins - mntcomp;
                                                            ImeCos.yr = ImeCos.yr + ths;
                                                            ImeCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    else
                                                    {
                                                        if (mntcomp > ImeCos.coins)
                                                        {
                                                            if (quotg > ImeCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else if (quotg < 1)
                                                            {
                                                                ImeCos.gold = ImeCos.gold - 1;
                                                                ImeCos.coins = ImeCos.coins + 1000 - modc;
                                                                ImeCos.yr = ImeCos.yr + ths;
                                                                ImeCos.mnt = gds;
                                                            }

                                                            else
                                                            {
                                                                ImeCos.gold = ImeCos.gold - quotg;
                                                                ImeCos.coins = ImeCos.coins - modc;
                                                                ImeCos.yr = ImeCos.yr + ths;
                                                                ImeCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < ImeCos.coins)
                                                        {

                                                            ImeCos.coins = ImeCos.coins - mntcomp;
                                                            ImeCos.yr = ImeCos.yr + ths;
                                                            ImeCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    break;

                                                case "3":
                                                    Console.WriteLine("=Cash In / Cash Out=");
                                                    Console.WriteLine("1 - Cash In");
                                                    Console.WriteLine("2 - Cash Out");
                                                    Console.WriteLine("Enter here: ");
                                                    cico = Console.ReadLine();

                                                    switch (cico)
                                                    {

                                                        case "1":

                                                            Console.WriteLine("\n How much do you wish to Cash In?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            ImeCos.rmoney = ImeCos.rmoney + adc;
                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to Cash Out?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            if (adc > ImeCos.rmoney)
                                                            {
                                                                Console.WriteLine("Insufficient Cash");
                                                            }
                                                            else
                                                            {
                                                                ImeCos.rmoney = ImeCos.rmoney - adc;
                                                            }

                                                            break;

                                                        default: break;
                                                    }
                                                    break;

                                                default: break;
                                            }
                                        } while (turn != "0");
                                        break;

                                }
                            } while (main != "x");
                        }
                        else { Console.WriteLine("Password Incorrect. Please Try Again\n"); }
                    }
                    else if (email.Equals(acc2.UserName))
                    {
                        pass = Password();

                        if (pass.Equals(acc2.PassWord))
                        {
                            do
                            { //show MainMenu method
                                main = MainMenu();

                                switch (main)
                                {
                                    case "1":
                                        //users infos. display
                                        PlayerInfo(Alvin);
                                        BackToMenu();
                                        break;
                                    case "2":
                                        //users tasks display
                                        GetTasks();
                                        do
                                        {
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine();
                                            if (turn == "1")
                                            {
                                                GetMissions(AlvTas);
                                            }
                                            else if (turn == "2")
                                            {
                                                GetAchives(AlvTas);
                                            }
                                        }
                                        while (turn != "0");
                                        break;

                                    case "3":
                                        //users contacts display
                                        GetAcq(AlvinAqu);
                                        do
                                        {

                                            Friends(Jane);
                                            Friends(Zhaila);
                                            Friends(Nia);
                                            Friends(Hector);
                                            Friends(Ronnie);
                                            Friends(Jary);
                                            Console.WriteLine("\nC - Call");
                                            Console.WriteLine("0 - return");
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "C":
                                                    Console.WriteLine("\nWho do you want to call?");
                                                    AlvinCon();
                                                    Console.WriteLine("\nContact = ");
                                                    con = Console.ReadLine();
                                                    var tact = Aafu.Find(x => x.namenum == con).ser;
                                                    var recname = Aafu.Find(x => x.namenum == con).tname;
                                                    if (tact == "Off      " || tact == "Busy     ")
                                                    {
                                                        Console.WriteLine("\nCalling. . .");
                                                        Thread.Sleep(3000);
                                                        Console.WriteLine("The service you contacted is either busy or off. Please try again later.\n");
                                                        ACLog.Add("Outgoing - " + recname);
                                                    }
                                                    else
                                                    {
                                                        //calling if not "busy" and converting it to "Busy"
                                                        if (con == "2")
                                                        {
                                                            CalRem(AlvinAqu, Zhaila, CZhaila);
                                                            Zhaila.ser = "Busy     ";
                                                            ACLog.Add("Outgoing - " + recname);
                                                        }
                                                        else if (con == "3")
                                                        {
                                                            CalRem(AlvinAqu, Nia, CNia);
                                                            Nia.ser = "Busy     ";
                                                            ACLog.Add("Outgoing - " + recname);
                                                        }
                                                    }
                                                    break;
                                                default: break;
                                            }


                                        } while (turn != "0");
                                        break;

                                    case "4":
                                        //displaying the users call history
                                        GetACalllog();
                                        BackToMenu();
                                        break;

                                    case "5":
                                        //computing the users finance and contract
                                        Console.WriteLine("\nFINANCE AND CONTRACT\n");
                                        do
                                        {
                                            Renew(AlvCos);
                                            FiCon();
                                            Console.WriteLine("Enter here:");

                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "1":
                                                    Console.WriteLine("\nMoney Conversion");
                                                    Console.WriteLine("1 - Coins to Gold: 1000 Coins = 1 Gold");
                                                    Console.WriteLine("2 - Gold to Coins: 1 Gold = 1000 Coins");
                                                    Console.WriteLine("3 - Cash to Gold: 1 Cash = 50 Golds");
                                                    Console.WriteLine("4 - Gold to Cash: 50 Golds = 1 Cash");
                                                    Console.WriteLine("Enter here: ");
                                                    gg = Console.ReadLine();

                                                    switch (gg)
                                                    {
                                                        case "1":

                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dcoins = Convert.ToInt32(Console.ReadLine());

                                                            if (dcoins > AlvCos.coins) { Console.WriteLine("You don't have enough coins"); }

                                                            else if (dcoins < 1000)
                                                            {
                                                                Console.WriteLine("Cannot be converted");
                                                            }
                                                            else
                                                            {
                                                                ctg = dcoins / 1000;
                                                                lom = dcoins % 1000;
                                                                diff = AlvCos.coins - dcoins;
                                                                AlvCos.gold = AlvCos.gold + ctg;
                                                                AlvCos.coins = diff + lom;
                                                            }

                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dgold = Convert.ToInt32(Console.ReadLine());

                                                            if (dgold > AlvCos.gold)
                                                            {
                                                                Console.WriteLine("You don't have enough gold");
                                                            }

                                                            else
                                                            {
                                                                gtc = dgold * 1000;
                                                                diff = AlvCos.gold - dgold;
                                                                AlvCos.coins = AlvCos.coins + gtc;
                                                                AlvCos.gold = diff;
                                                            }

                                                            break;

                                                        case "3":
                                                            Console.WriteLine("\nHow much cash you wish to convert to gold?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            sum = prod * 50;
                                                            AlvCos.gold = AlvCos.gold + sum;
                                                            AlvCos.rmoney = AlvCos.rmoney - prod;

                                                            break;

                                                        case "4":
                                                            Console.WriteLine("\nHow much gold you wish to convert to cash?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            if (prod < 50)
                                                            {
                                                                Console.WriteLine("Insufficient gold/s");
                                                            }
                                                            else
                                                            {
                                                                sum = prod / 50;
                                                                AlvCos.rmoney = AlvCos.rmoney + sum;
                                                                AlvCos.gold = AlvCos.gold - prod;
                                                            }

                                                            break;

                                                        default: break;
                                                    }

                                                    break;

                                                case "2":

                                                    Console.WriteLine("\nHow much time do you wish to extend?");
                                                    Console.WriteLine("1 month = 500 coins");
                                                    Console.WriteLine("3 months = 1 gold and 500 coins / 1500 coins");
                                                    Console.WriteLine("6 months = 3 golds / 3000 coins");
                                                    Console.WriteLine("How many month/s? ");
                                                    mos = Convert.ToInt32(Console.ReadLine());

                                                    months = mos + AlvCos.mnt;
                                                    mntcomp = mos * 500;
                                                    quotg = mntcomp / 1000;
                                                    modc = mntcomp % 1000;
                                                    ths = months / 12;
                                                    gds = months % 12;

                                                    if (months >= 12)
                                                    {
                                                        if (mntcomp > AlvCos.coins)
                                                        {
                                                            if (quotg > AlvCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else
                                                            {
                                                                AlvCos.gold = AlvCos.gold - quotg;
                                                                AlvCos.coins = AlvCos.coins - modc;
                                                                AlvCos.yr = AlvCos.yr + ths;
                                                                AlvCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < AlvCos.coins)
                                                        {
                                                            AlvCos.coins = AlvCos.coins - mntcomp;
                                                            AlvCos.yr = AlvCos.yr + ths;
                                                            AlvCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    else
                                                    {
                                                        if (mntcomp > AlvCos.coins)
                                                        {
                                                            if (quotg > AlvCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else if (quotg < 1)
                                                            {
                                                                AlvCos.gold = AlvCos.gold - 1;
                                                                AlvCos.coins = AlvCos.coins + 1000 - modc;
                                                                AlvCos.yr = AlvCos.yr + ths;
                                                                AlvCos.mnt = gds;
                                                            }

                                                            else
                                                            {
                                                                AlvCos.gold = AlvCos.gold - quotg;
                                                                AlvCos.coins = AlvCos.coins - modc;
                                                                AlvCos.yr = AlvCos.yr + ths;
                                                                AlvCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < AlvCos.coins)
                                                        {

                                                            AlvCos.coins = AlvCos.coins - mntcomp;
                                                            AlvCos.yr = AlvCos.yr + ths;
                                                            AlvCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    break;

                                                case "3":
                                                    Console.WriteLine("=Cash In / Cash Out=");
                                                    Console.WriteLine("1 - Cash In");
                                                    Console.WriteLine("2 - Cash Out");
                                                    Console.WriteLine("Enter here: ");
                                                    cico = Console.ReadLine();

                                                    switch (cico)
                                                    {

                                                        case "1":

                                                            Console.WriteLine("\n How much do you wish to Cash In?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            AlvCos.rmoney = AlvCos.rmoney + adc;
                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to Cash Out?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            if (adc > AlvCos.rmoney)
                                                            {
                                                                Console.WriteLine("Insufficient Cash");
                                                            }
                                                            else
                                                            {
                                                                AlvCos.rmoney = AlvCos.rmoney - adc;
                                                            }

                                                            break;

                                                        default: break;
                                                    }
                                                    break;

                                                default: break;
                                            }
                                        } while (turn != "0");
                                        break;

                                }
                            } while (main != "x");
                        }
                        else { Console.WriteLine("Password Incorrect. Please Try Again\n"); }
                    }
                    else if (email.Equals(acc3.UserName))
                    {
                        pass = Password();

                        if (pass.Equals(acc3.PassWord))
                        {
                            do
                            { //show MainMenu method
                                main = MainMenu();

                                switch (main)
                                {
                                    case "1":
                                        //users infos. display
                                        PlayerInfo(Zachary);
                                        BackToMenu();
                                        break;
                                    case "2":
                                        //users tasks display
                                        GetTasks();
                                        do
                                        {
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine();
                                            if (turn == "1")
                                            {
                                                GetMissions(ZacTas);
                                                Console.WriteLine("-Hidden Mission= (Failure of keeping this mission hidden may result on death)");
                                                Console.WriteLine(h);
                                            }
                                            else if (turn == "2")
                                            {
                                                GetAchives(ZacTas);
                                            }
                                        }
                                        while (turn != "0");
                                        break;

                                    case "3":
                                        //users contacts display
                                        GetAcq(ZacharyAqu);
                                        do
                                        {

                                            Friends(Lillian);
                                            Friends(Annalyn);
                                            Friends(Aranela);
                                            Friends(Carter);
                                            Friends(Hannah);
                                            Friends(Devana);
                                            Console.WriteLine("\nC - Call");
                                            Console.WriteLine("0 - return");
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "C":
                                                    Console.WriteLine("\nWho do you want to call?");
                                                    ZachCon();
                                                    Console.WriteLine("\nContact = ");
                                                    con = Console.ReadLine();
                                                    var tact = Zafu.Find(x => x.namenum == con).ser;
                                                    var recname = Zafu.Find(x => x.namenum == con).tname;
                                                    if (tact == "Off      " || tact == "Busy     ")
                                                    {
                                                        Console.WriteLine("\nCalling. . .");
                                                        Thread.Sleep(3000);
                                                        Console.WriteLine("The service you contacted is either busy or off. Please try again later.\n");
                                                        ZCLog.Add("Outgoing - " + recname);
                                                    }
                                                    else
                                                    {
                                                        //calling if not "busy" and converting it to "Busy"
                                                        if (con == "1")
                                                        {
                                                            CalRem(ZacharyAqu, Lillian, CLillian);
                                                            Lillian.ser = "Busy     ";
                                                            ZCLog.Add("Outgoing - " + recname);
                                                        }
                                                        else if (con == "3")
                                                        {
                                                            CalRem(ZacharyAqu, Aranela, CAranela);
                                                            Aranela.ser = "Busy     ";
                                                            ZCLog.Add("Outgoing - " + recname);
                                                        }
                                                    }
                                                    break;
                                                default: break;
                                            }


                                        } while (turn != "0");
                                        break;

                                    case "4":
                                        //displaying the users call history
                                        GetZCalllog();
                                        BackToMenu();
                                        break;

                                    case "5":
                                        //computing the users finance and contract
                                        Console.WriteLine("\nFINANCE AND CONTRACT\n");
                                        do
                                        {
                                            Renew(ZacCos);
                                            FiCon();
                                            Console.WriteLine("Enter here:");

                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "1":
                                                    Console.WriteLine("\nMoney Conversion");
                                                    Console.WriteLine("1 - Coins to Gold: 1000 Coins = 1 Gold");
                                                    Console.WriteLine("2 - Gold to Coins: 1 Gold = 1000 Coins");
                                                    Console.WriteLine("3 - Cash to Gold: 1 Cash = 50 Golds");
                                                    Console.WriteLine("4 - Gold to Cash: 50 Golds = 1 Cash");
                                                    Console.WriteLine("Enter here: ");
                                                    gg = Console.ReadLine();

                                                    switch (gg)
                                                    {
                                                        case "1":

                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dcoins = Convert.ToInt32(Console.ReadLine());

                                                            if (dcoins > ZacCos.coins) { Console.WriteLine("You don't have enough coins"); }

                                                            else if (dcoins < 1000)
                                                            {
                                                                Console.WriteLine("Cannot be converted");
                                                            }
                                                            else
                                                            {
                                                                ctg = dcoins / 1000;
                                                                lom = dcoins % 1000;
                                                                diff = ZacCos.coins - dcoins;
                                                                ZacCos.gold = ZacCos.gold + ctg;
                                                                ZacCos.coins = diff + lom;
                                                            }

                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dgold = Convert.ToInt32(Console.ReadLine());

                                                            if (dgold > ZacCos.gold)
                                                            {
                                                                Console.WriteLine("You don't have enough gold");
                                                            }

                                                            else
                                                            {
                                                                gtc = dgold * 1000;
                                                                diff = ZacCos.gold - dgold;
                                                                ZacCos.coins = ZacCos.coins + gtc;
                                                                ZacCos.gold = diff;
                                                            }

                                                            break;

                                                        case "3":
                                                            Console.WriteLine("\nHow much cash you wish to convert to gold?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            sum = prod * 50;
                                                            ZacCos.gold = ZacCos.gold + sum;
                                                            ZacCos.rmoney = ZacCos.rmoney - prod;

                                                            break;

                                                        case "4":
                                                            Console.WriteLine("\nHow much gold you wish to convert to cash?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            if (prod < 50)
                                                            {
                                                                Console.WriteLine("Insufficient gold/s");
                                                            }
                                                            else
                                                            {
                                                                sum = prod / 50;
                                                                ZacCos.rmoney = ZacCos.rmoney + sum;
                                                                ZacCos.gold = ZacCos.gold - prod;
                                                            }

                                                            break;

                                                        default: break;
                                                    }

                                                    break;

                                                case "2":

                                                    Console.WriteLine("\nHow much time do you wish to extend?");
                                                    Console.WriteLine("1 month = 500 coins");
                                                    Console.WriteLine("3 months = 1 gold and 500 coins / 1500 coins");
                                                    Console.WriteLine("6 months = 3 golds / 3000 coins");
                                                    Console.WriteLine("How many month/s? ");
                                                    mos = Convert.ToInt32(Console.ReadLine());

                                                    months = mos + ZacCos.mnt;
                                                    mntcomp = mos * 500;
                                                    quotg = mntcomp / 1000;
                                                    modc = mntcomp % 1000;
                                                    ths = months / 12;
                                                    gds = months % 12;

                                                    if (months >= 12)
                                                    {
                                                        if (mntcomp > ZacCos.coins)
                                                        {
                                                            if (quotg > ZacCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else
                                                            {
                                                                ZacCos.gold = ZacCos.gold - quotg;
                                                                ZacCos.coins = ZacCos.coins - modc;
                                                                ZacCos.yr = ZacCos.yr + ths;
                                                                ZacCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < ZacCos.coins)
                                                        {
                                                            ZacCos.coins = ZacCos.coins - mntcomp;
                                                            ZacCos.yr = ZacCos.yr + ths;
                                                            ZacCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    else
                                                    {
                                                        if (mntcomp > ZacCos.coins)
                                                        {
                                                            if (quotg > ZacCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else if (quotg < 1)
                                                            {
                                                                ZacCos.gold = ZacCos.gold - 1;
                                                                ZacCos.coins = ZacCos.coins + 1000 - modc;
                                                                ZacCos.yr = ZacCos.yr + ths;
                                                                ZacCos.mnt = gds;
                                                            }

                                                            else
                                                            {
                                                                ZacCos.gold = ZacCos.gold - quotg;
                                                                ZacCos.coins = ZacCos.coins - modc;
                                                                ZacCos.yr = ZacCos.yr + ths;
                                                                ZacCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < ZacCos.coins)
                                                        {

                                                            ZacCos.coins = ZacCos.coins - mntcomp;
                                                            ZacCos.yr = ZacCos.yr + ths;
                                                            ZacCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    break;

                                                case "3":
                                                    Console.WriteLine("=Cash In / Cash Out=");
                                                    Console.WriteLine("1 - Cash In");
                                                    Console.WriteLine("2 - Cash Out");
                                                    Console.WriteLine("Enter here: ");
                                                    cico = Console.ReadLine();

                                                    switch (cico)
                                                    {

                                                        case "1":

                                                            Console.WriteLine("\n How much do you wish to Cash In?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            ZacCos.rmoney = ZacCos.rmoney + adc;
                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to Cash Out?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            if (adc > ZacCos.rmoney)
                                                            {
                                                                Console.WriteLine("Insufficient Cash");
                                                            }
                                                            else
                                                            {
                                                                ZacCos.rmoney = ZacCos.rmoney - adc;
                                                            }

                                                            break;

                                                        default: break;
                                                    }
                                                    break;

                                                default: break;
                                            }
                                        } while (turn != "0");
                                        break;

                                }
                            } while (main != "x");
                        }
                        else { Console.WriteLine("Password Incorrect. Please Try Again\n"); }
                    }
                    else if (email.Equals(acc4.UserName))
                    {
                        pass = Password();

                        if (pass.Equals(acc4.PassWord))
                        {
                            do
                            { //show MainMenu method
                                main = MainMenu();

                                switch (main)
                                {
                                    case "1":
                                        //users infos. display
                                        PlayerInfo(NewMem);
                                        BackToMenu();
                                        break;
                                    case "2":
                                        //users tasks display
                                        GetTasks();
                                        do
                                        {
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine();
                                            if (turn == "1")
                                            {
                                                GetMissions(NewTas);
                                            }
                                            else if (turn == "2")
                                            {
                                                GetAchives(NewTas);
                                            }
                                        }
                                        while (turn != "0");
                                        break;

                                    case "3":
                                        //users contacts display
                                        GetAcq(NewMemAqu);
                                        do
                                        {

                                            Console.WriteLine("You have not yet made any friends");
                                            Console.WriteLine("\nC - Call");
                                            Console.WriteLine("0 - return");
                                            Console.WriteLine("Enter here: ");
                                            turn = Console.ReadLine().ToUpper();

                                        } while (turn != "0");
                                        break;

                                    case "4":
                                        //displaying the users call history
                                        Console.WriteLine("LIST EMPTY");
                                        BackToMenu();
                                        break;

                                    case "5":
                                        //computing the users finance and contract
                                        Console.WriteLine("\nFINANCE AND CONTRACT\n");
                                        do
                                        {
                                            Renew(NewCos);
                                            FiCon();
                                            Console.WriteLine("Enter here:");

                                            turn = Console.ReadLine().ToUpper();

                                            switch (turn)
                                            {
                                                case "1":
                                                    Console.WriteLine("\nMoney Conversion");
                                                    Console.WriteLine("1 - Coins to Gold: 1000 Coins = 1 Gold");
                                                    Console.WriteLine("2 - Gold to Coins: 1 Gold = 1000 Coins");
                                                    Console.WriteLine("3 - Cash to Gold: 1 Cash = 50 Golds");
                                                    Console.WriteLine("4 - Gold to Cash: 50 Golds = 1 Cash");
                                                    Console.WriteLine("Enter here: ");
                                                    gg = Console.ReadLine();

                                                    switch (gg)
                                                    {
                                                        case "1":

                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dcoins = Convert.ToInt32(Console.ReadLine());

                                                            if (dcoins > NewCos.coins) { Console.WriteLine("You don't have enough coins"); }

                                                            else if (dcoins < 1000)
                                                            {
                                                                Console.WriteLine("Cannot be converted");
                                                            }
                                                            else
                                                            {
                                                                ctg = dcoins / 1000;
                                                                lom = dcoins % 1000;
                                                                diff = NewCos.coins - dcoins;
                                                                NewCos.gold = NewCos.gold + ctg;
                                                                NewCos.coins = diff + lom;
                                                            }

                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to convert?");
                                                            dgold = Convert.ToInt32(Console.ReadLine());

                                                            if (dgold > NewCos.gold)
                                                            {
                                                                Console.WriteLine("You don't have enough gold");
                                                            }

                                                            else
                                                            {
                                                                gtc = dgold * 1000;
                                                                diff = NewCos.gold - dgold;
                                                                NewCos.coins = NewCos.coins + gtc;
                                                                NewCos.gold = diff;
                                                            }

                                                            break;

                                                        case "3":
                                                            Console.WriteLine("\nHow much cash you wish to convert to gold?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            sum = prod * 50;
                                                            NewCos.gold = NewCos.gold + sum;
                                                            NewCos.rmoney = NewCos.rmoney - prod;

                                                            break;

                                                        case "4":
                                                            Console.WriteLine("\nHow much gold you wish to convert to cash?");
                                                            prod = Convert.ToInt32(Console.ReadLine());

                                                            if (prod < 50)
                                                            {
                                                                Console.WriteLine("Insufficient gold/s");
                                                            }
                                                            else
                                                            {
                                                                sum = prod / 50;
                                                                NewCos.rmoney = NewCos.rmoney + sum;
                                                                NewCos.gold = NewCos.gold - prod;
                                                            }

                                                            break;

                                                        default: break;
                                                    }

                                                    break;

                                                case "2":

                                                    Console.WriteLine("\nHow much time do you wish to extend?");
                                                    Console.WriteLine("1 month = 500 coins");
                                                    Console.WriteLine("3 months = 1 gold and 500 coins / 1500 coins");
                                                    Console.WriteLine("6 months = 3 golds / 3000 coins");
                                                    Console.WriteLine("How many month/s? ");
                                                    mos = Convert.ToInt32(Console.ReadLine());

                                                    months = mos + NewCos.mnt;
                                                    mntcomp = mos * 500;
                                                    quotg = mntcomp / 1000;
                                                    modc = mntcomp % 1000;
                                                    ths = months / 12;
                                                    gds = months % 12;

                                                    if (months >= 12)
                                                    {
                                                        if (mntcomp > NewCos.coins)
                                                        {
                                                            if (quotg > NewCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else
                                                            {
                                                                NewCos.gold = NewCos.gold - quotg;
                                                                NewCos.coins = NewCos.coins - modc;
                                                                NewCos.yr = NewCos.yr + ths;
                                                                NewCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < NewCos.coins)
                                                        {
                                                            NewCos.coins = NewCos.coins - mntcomp;
                                                            NewCos.yr = NewCos.yr + ths;
                                                            NewCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    else
                                                    {
                                                        if (mntcomp > NewCos.coins)
                                                        {
                                                            if (quotg > NewCos.gold)
                                                            {
                                                                Console.WriteLine("Insufficient Funds");
                                                            }
                                                            else if (quotg < 1)
                                                            {
                                                                NewCos.gold = NewCos.gold - 1;
                                                                NewCos.coins = NewCos.coins + 1000 - modc;
                                                                NewCos.yr = NewCos.yr + ths;
                                                                NewCos.mnt = gds;
                                                            }

                                                            else
                                                            {
                                                                NewCos.gold = NewCos.gold - quotg;
                                                                NewCos.coins = NewCos.coins - modc;
                                                                NewCos.yr = NewCos.yr + ths;
                                                                NewCos.mnt = gds;
                                                            }

                                                        }
                                                        else if (mntcomp < NewCos.coins)
                                                        {

                                                            NewCos.coins = NewCos.coins - mntcomp;
                                                            NewCos.yr = NewCos.yr + ths;
                                                            NewCos.mnt = gds;

                                                        }
                                                        else { Console.WriteLine("Insufficient Money"); }
                                                    }

                                                    break;

                                                case "3":
                                                    Console.WriteLine("=Cash In / Cash Out=");
                                                    Console.WriteLine("1 - Cash In");
                                                    Console.WriteLine("2 - Cash Out");
                                                    Console.WriteLine("Enter here: ");
                                                    cico = Console.ReadLine();

                                                    switch (cico)
                                                    {

                                                        case "1":

                                                            Console.WriteLine("\n How much do you wish to Cash In?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            NewCos.rmoney = NewCos.rmoney + adc;
                                                            break;

                                                        case "2":
                                                            Console.WriteLine("\nHow much do you wish to Cash Out?");
                                                            adc = Convert.ToInt32(Console.ReadLine());

                                                            if (adc > NewCos.rmoney)
                                                            {
                                                                Console.WriteLine("Insufficient Cash");
                                                            }
                                                            else
                                                            {
                                                                NewCos.rmoney = NewCos.rmoney - adc;
                                                            }

                                                            break;

                                                        default: break;
                                                    }
                                                    break;

                                                default: break;
                                            }
                                        } while (turn != "0");
                                        break;

                                }
                            } while (main != "x");
                        }
                        else { Console.WriteLine("Password Incorrect. Please Try Again\n"); }
                    }

                    else { Console.WriteLine("Invalid email!\n"); break; }

                    break;

                case "2":
                    string liation, nick, der, lity, ing, ition, us, rh, sn, usename, pw, sts;
                    int bm, bd, old;
                    Console.WriteLine("===SIGN UP===");
                    Console.WriteLine("Username:");
                    sn = Console.ReadLine();
                    NewMem.name = sn;
                    do
                    { //getting the birthday of the new user
                        Console.WriteLine("Birth Month: mm [01 - 12]");
                        bm = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Birth Day: dd [01-31]");
                        bd = Convert.ToInt32(Console.ReadLine());
                        if (bm <= 12 && bd <= 31)
                        { continue; }
                        else { Console.WriteLine("Input Invalid"); }
                    } while (bm > 12 || bd > 31 || bm == 2 && bd > 29);
                    NewMem.bday = bm + "-" + bd;
                    //getting password
                    Console.WriteLine("Password: ");
                    pw = Console.ReadLine();
                    acc4.PassWord = pw;

                    //making the account
                    usename = $"{sn}#{bm}{bd}";
                    acc4.UserName = usename;

                    //getting infos of the users.
                    Console.WriteLine("\n~~~INFORMATION FORM~~~");

                    Console.WriteLine("Write NickName: ");
                    nick = Console.ReadLine();
                    NewMem.nn = nick;

                    Console.WriteLine("Write Age: ");
                    old = Convert.ToInt32(Console.ReadLine());
                    NewMem.age = old;

                    Console.WriteLine("Write Gender: ");
                    der = Console.ReadLine();
                    NewMem.gen = der;

                    Console.WriteLine("Ability: ");
                    lity = Console.ReadLine();
                    NewMem.abi = lity;

                    do
                    {
                        Console.WriteLine("Rank : F ~ S ");
                        ing = Console.ReadLine().ToUpper();

                        if (anrk.Contains(ing)) { continue; }
                        else { Console.WriteLine("Input Invalid"); }

                    } while (!(anrk.Contains(ing)));
                    NewMem.rank = ing;

                    do
                    {
                        Console.WriteLine("Position: Offense / Defense / Support");
                        ition = Console.ReadLine().ToLower();

                        if (tion.Contains(ition)) { continue; }
                        else { Console.WriteLine("Input Invalid"); }

                    } while (!(tion.Contains(ition)));
                    NewMem.pos = ition;

                    GetStatus();
                    us = Console.ReadLine();

                    var resul = ship.Find(x => x.snum == us).sstats;
                    if (us == "4")
                    {
                        Console.WriteLine("Enter your status: ");
                        rh = Console.ReadLine();
                        us = rh;
                    }
                    else { us = resul; }
                    oth.sstats = us;
                    NewMem.stat = us;

                    //guild lists
                    Guild KOGF = new();
                    KOGF.number = "1";
                    KOGF.gname = "Knights of the Golden Flame";

                    Guild UG = new();
                    UG.number = "2";
                    UG.gname = "Unlock Guild";

                    Guild AR = new();
                    AR.number = "3";
                    AR.gname = "Arcane Rouge";

                    Guild SGH = new();
                    SGH.number = "4";
                    SGH.gname = "Sun's Grace Home";

                    Guild NC = new();
                    NC.number = "5";
                    NC.gname = "Night Chaser";

                    Guild DD = new();
                    DD.number = "6";
                    DD.gname = "Dawn&Dusk";

                    Guild BT = new();
                    BT.number = "7";
                    BT.gname = "Bloody Thorns";

                    Guild others = new();
                    others.number = "8";

                    guilds.Add(others);
                    guilds.Add(KOGF);
                    guilds.Add(UG);
                    guilds.Add(AR);
                    guilds.Add(SGH);
                    guilds.Add(NC);
                    guilds.Add(DD);
                    guilds.Add(BT);

                    Console.WriteLine("Guild: ");
                    GetGuild();
                    string agui = Console.ReadLine();
                    string gui;

                    var result = guilds.Find(x => x.number == agui).gname;
                    if (agui == "8")
                    {
                        Console.WriteLine("Enter your guild: ");
                        gui = Console.ReadLine();
                    }
                    else { gui = result; }
                    others.gname = gui;

                    liation = gui;
                    NewMem.affi = liation;

                    //getting service
                    Acqu On1 = new();
                    On1.type = "1";
                    On1.status = "On";
                    afu.Add(On1);

                    Acqu Off2 = new();
                    Off2.type = "2";
                    Off2.status = "Off";
                    afu.Add(Off2);

                    Acqu Bz3 = new();
                    Bz3.type = "3";
                    Bz3.status = "Busy";
                    afu.Add(Bz3);

                    Acqu othr4 = new();
                    othr4.type = "4";
                    afu.Add(othr4);

                    Console.WriteLine("\n What is your current service: ");
                    GetService();
                    string vice = Console.ReadLine();
                    string vice2;

                    var rsult = afu.Find(x => x.type == vice).status;
                    if (vice == "4")
                    {
                        Console.WriteLine("Enter your service:");
                        vice2 = Console.ReadLine();
                        sts = vice2;

                    }
                    else { sts = rsult; }

                    othr4.status = sts;
                    NewMemAqu.ser = sts;

                    //displaying the given account of the new user
                    Console.WriteLine("\nYour Username is " + usename);
                    Console.WriteLine("Your Password is " + pw);
                    break;

                default: break;
            }
            if (input.ToLower() == "x")
            {
                Console.WriteLine("Program Terminated");
                break;
            }
        } while (true);
    }

    static string Welcome()
    {
        Console.WriteLine("\n!!WELCOME TO ACCOUNT SYSTEM MANAGEMENT!!");
        Console.WriteLine("1 - Log In");
        Console.WriteLine("2 - Sign Up");
        Console.WriteLine("x - Exit");
        Console.WriteLine("\nEnter here: ");
        string choice = Console.ReadLine();

        return choice;
    }
    static string BackToMenu()
    {
        Console.WriteLine("\nPress any key to Return");
        Console.WriteLine("Enter here: ");
        string re = Console.ReadLine();

        return re;
    }
    static string Password()
    {
        Console.WriteLine("Password: ");
        string word = Console.ReadLine();

        return word;
    }
    static string MainMenu()
    {
        Console.WriteLine("\n~~~MAIN MENU~~~");
        Console.WriteLine("1 - Information");
        Console.WriteLine("2 - Tasks");
        Console.WriteLine("3 - Contacts");
        Console.WriteLine("4 - Logs");
        Console.WriteLine("5 - Finance and Contract");
        Console.WriteLine("X - Log Out");
        Console.WriteLine("\nEnter here: ");
        string menu = Console.ReadLine();

        return menu;

    }
    static void PlayerInfo(MemInfo playinfo)
    {
        Console.WriteLine("\n~MEMBER INFORMATION~");
        Console.WriteLine("Affiliation: " + playinfo.affi);
        Console.WriteLine("Name: " + playinfo.name);
        Console.WriteLine("Nickname: " + playinfo.nn);
        Console.WriteLine("Age: " + playinfo.age);
        Console.WriteLine("Gender: " + playinfo.gen);
        Console.WriteLine("Birthday: " + playinfo.bday);
        Console.WriteLine("Ability: " + playinfo.abi);
        Console.WriteLine("Rank: " + playinfo.rank);
        Console.WriteLine("Position: " + playinfo.pos);
        Console.WriteLine("Status: " + playinfo.stat);

    }
    static void GetTasks()
    {
        Console.WriteLine("\n=TASKS=: ");
        Console.WriteLine("1 - Missions");
        Console.WriteLine("2 - Achievements");
        Console.WriteLine("0 - return");

    }
    static void GetMissions(Misn tma)
    {
        Console.WriteLine("\n~MISSION~");
        Console.WriteLine("-Daily Missions= (Failure of the Daily will result in mission tax)");
        Console.WriteLine(tma.getdai);

        Console.WriteLine("\n-Incomplete=");
        Console.WriteLine(tma.getin + "\n");

    }
    static void GetAchives(Misn tam)
    {
        Console.WriteLine("\n~ACHIEVEMENTS~\n");
        Console.WriteLine(tam.getach + "\n");

    }
    static void GetAcq(Acqu aqu)
    {
        Console.WriteLine("\n~CONTACTS~\n");
        Console.WriteLine("Address: " + aqu.add);
        Console.WriteLine("Service: " + aqu.ser);
        Console.WriteLine("Status: " + aqu.status);
        Console.WriteLine("\n=================\n");
        Console.WriteLine("{ACQUAINTANCES}\n");
        Console.WriteLine("=Service= | =Names=    | =Address= ");
    }
    static void GetGuild()
    {
        Console.WriteLine("Choose guild to apply: ");
        Console.WriteLine("1 - Knights of the Golden Flame");
        Console.WriteLine("2 - Unlock");
        Console.WriteLine("3 - Arcane Rouge ");
        Console.WriteLine("4 - Sun's Grace Home");
        Console.WriteLine("5 - Night Chaser");
        Console.WriteLine("6 - Dawn&Dusk");
        Console.WriteLine("7 - Bloody Thorns");
        Console.WriteLine("8 - Others");
        Console.WriteLine("Enter here: ");

    }
    static void GetService()
    {
        Console.WriteLine("1 - On       ");
        Console.WriteLine("2 - Off      ");
        Console.WriteLine("3 - Busy     ");
    }
    static void GetStatus()
    {
        Console.WriteLine("Enter your Status: ");
        Console.WriteLine("1 -Single");
        Console.WriteLine("2 -Taken");
        Console.WriteLine("3 -Complicated");
        Console.WriteLine("4 -Others");
    }
    static void Renew(ConCha compgoco)
    {
        Console.WriteLine("\nYour Balance: " + compgoco.rmoney + " cash, " + compgoco.gold + " gold/s and " + compgoco.coins + " coin/s");
        Console.WriteLine("Your current contract is: " + compgoco.yr + " year/s and " + compgoco.mnt + " month/s");
    }
    static void FiCon()
    {
        Console.WriteLine("\nChoose: ");
        Console.WriteLine("1 - Convert Money");
        Console.WriteLine("2 - Extend International Porter License (IPL) Contract");
        Console.WriteLine("3 - Cash In / Cash out");
        Console.WriteLine("0 - return");
    }
    static void Friends(Acqu recp)
    {
        Console.WriteLine($"{recp.ser} | {recp.tname} | {recp.add}");
    }
    static void GetICalllog()
    {
        Console.WriteLine("\n~LOGS~\n");
        Console.WriteLine("(Call Record)\n");
        Console.WriteLine("-Today~");
        for (int i = 0; i < ICLog.Count; i++)
        {
            Console.WriteLine(ICLog[i]);
        }
    }
    static void GetACalllog()
    {
        Console.WriteLine("\n~LOGS~\n");
        Console.WriteLine("(Call Record)\n");
        Console.WriteLine("-Today~");
        for (int j = 0; j < ACLog.Count; j++)
        {
            Console.WriteLine(ACLog[j]);
        }
    }
    static void GetZCalllog()
    {
        Console.WriteLine("\n~LOGS~\n");
        Console.WriteLine("(Call Record)\n");
        Console.WriteLine("-Today~");
        for (int k = 0; k < ZCLog.Count; k++)
        {
            Console.WriteLine(ZCLog[k]);
        }
    }
    static void CalRem(Acqu rnm, Acqu fnm, Call hem)
    {
        ConsoleKeyInfo tak;
        Console.WriteLine("\nCalling . . .");
        Thread.Sleep(3000);

        Console.WriteLine($"\n{otp} {fnm.tname}:");
        Console.WriteLine(hem.call1);
        Console.Write($"{rnm.tname}: ");
        tak = Console.ReadKey();

        Console.WriteLine($"\n\n{otp} {fnm.tname}:");
        Console.WriteLine(hem.call2);
        Console.Write($"{rnm.tname}: ");
        tak = Console.ReadKey();

        Console.WriteLine($"\n\n{otp} {fnm.tname}:");
        Console.WriteLine(hem.call3);
        Console.Write($"{rnm.tname}: ");
        tak = Console.ReadKey();

        Console.WriteLine($"\n\n{otp} {fnm.tname}:");
        Console.WriteLine(hem.endcall);
        Thread.Sleep(5000);
        Console.WriteLine("\nCall Ended\n");

    }
    static void ImeraCon()
    {
        Console.WriteLine("1 - Alleia");
        Console.WriteLine("2 - Fillarie");
        Console.WriteLine("3 - Dylan");
        Console.WriteLine("4 - Ellesrie");
        Console.WriteLine("5 - Reidyn");
        Console.WriteLine("6 - Nelson");
        Console.WriteLine("7 - Carielle");
        Console.WriteLine("8 - Jyson");
    }
    static void AlvinCon()
    {
        Console.WriteLine("1 - Jane");
        Console.WriteLine("2 - Zhaila");
        Console.WriteLine("3 - Nia");
        Console.WriteLine("4 - Hector");
        Console.WriteLine("5 - Ronnie");
        Console.WriteLine("6 - Jary");
    }
    static void ZachCon()
    {
        Console.WriteLine("1 - Lillian");
        Console.WriteLine("2 - Annalyn");
        Console.WriteLine("3 - Aranela");
        Console.WriteLine("4 - Carter");
        Console.WriteLine("5 - Hannah");
        Console.WriteLine("6 - Devana");
    }

}