// See https://aka.ms/new-console-template for more information
using Telefon_Szolgáltatás;

Szolgáltató szolgáltató = new Szolgáltató("Telekom", "Budapest, Pesti út 237/P, 1171", "+36 30 4444434", 
    new Alapadatok(27, 100, 50, 1500)) ;

szolgáltató.főnök = new Főnök("Boss Elek", "Rózsadomb Pálmafa u. 99.", "+36 30 1111111", "Mercedes");

szolgáltató.beosztottLista.Add(new Beosztott(1, "Adat Gazda", "Pécel, Maglódi út 57, 2119", "+36 30 1569631", "Adatrögzítő"));
szolgáltató.beosztottLista.Add(new Beosztott(2, "Kő Sanyi", "Budapest, Pesti út 86-88, 1173", "+36 30 1167781", "RendszerKarbantartó"));
szolgáltató.beosztottLista.Add(new Beosztott(3, "Ede Győző", "Budapest, Kozma u. 8-10, 1108", "+36 30 1672111", "Takarító"));
szolgáltató.beosztottLista.Add(new Beosztott(4, "Orbán Iktor", "Budapest, Honvéd u. 47, 1185", "+36 30 1111111", "Ügyintéző"));
szolgáltató.beosztottLista.Add(new Beosztott(5, "Kerek Ferenc", "Budapest, Dráva utca 38, 1182", "+36 30 1211742", "Ügyintéző"));
szolgáltató.beosztottLista.Add(new Beosztott(6, "Sólyom Pista", "Palmrothintie 2, 33950 Pirkkala, Finnország", "+36 30 1675531", "Adatrögzítő"));
szolgáltató.ügyfélLista.Add(new Ügyfél(1, "Sárga János", "+36 30 3960001", "Budapest, Hunyadi u. 42, 1174", szolgáltató.getBeosztott(4)));
szolgáltató.ügyfélLista.Add(new Ügyfél(2, "Sárga Edit", "+36 30 3960002", "Budapest, Hunyadi u. 42, 1174", szolgáltató.getBeosztott(4)));
szolgáltató.ügyfélLista.Add(new Ügyfél(3, "Sárga Gyöngyös", "+36 30 3960003", "Budapest, Hunyadi u. 42, 1174", szolgáltató.getBeosztott(4)));
szolgáltató.ügyfélLista.Add(new Ügyfél(4, "Sárga Dani", "+36 30 3960004", "Budapest, Hunyadi u. 42, 1174", szolgáltató.getBeosztott(4)));
szolgáltató.ügyfélLista.Add(new Ügyfél(5, "Csákány Péter", "+36 30 3960005", "Budapest, Akácvirág u. 30, 1173", szolgáltató.getBeosztott(5)));
szolgáltató.ügyfélLista.Add(new Ügyfél(6, "Csákány Péter", "+36 30 3960006", "Budapest, Akácvirág u. 30, 1173", szolgáltató.getBeosztott(5)));
szolgáltató.ügyfélLista.Add(new Ügyfél(7, "Csákány Fruzsina", "+36 30 3960007", "Budapest, Akácvirág u. 30, 1173", szolgáltató.getBeosztott(5)));
szolgáltató.ügyfélLista.Add(new Ügyfél(8, "Csákány Réka", "+36 30 3960008", "Budapest, Akácvirág u. 30, 1173", szolgáltató.getBeosztott(5)));
szolgáltató.ügyfélLista.Add(new Ügyfél(9, "Ganz Petra", "+36 30 3960009", "Budapest, Timur u. 29, 1162", szolgáltató.getBeosztott(5)));
szolgáltató.ügyfélLista.Add(new Ügyfél(10, "Csoro Lali", "+36 30 3960010", "Fót, Fehérkő u. 4/A, 2151", szolgáltató.getBeosztott(4)));
szolgáltató.ügyfélLista.Add(new Ügyfél(11, "Little Big", "+36 30 3960011", "Pilis, Bocskai u. 5, 2721", szolgáltató.getBeosztott(5)));
szolgáltató.számlaLista.Add(new Számla(345445, szolgáltató.getÜgyfél(1), 7288, false)); 
szolgáltató.számlaLista.Add(new Számla(449442, szolgáltató.getÜgyfél(1), 7889, true)); 
szolgáltató.számlaLista.Add(new Számla(777565, szolgáltató.getÜgyfél(2), 3089, false)); 
szolgáltató.számlaLista.Add(new Számla(543543, szolgáltató.getÜgyfél(7), 7889, false)); 
szolgáltató.számlaLista.Add(new Számla(893543, szolgáltató.getÜgyfél(11), 3889, true)); 
szolgáltató.számlaLista.Add(new Számla(942357, szolgáltató.getÜgyfél(2), 3388, false)); 
szolgáltató.számlaLista.Add(new Számla(549973, szolgáltató.getÜgyfél(4), 3339, true)); 
szolgáltató.számlaLista.Add(new Számla(455569, szolgáltató.getÜgyfél(9), 7889, false)); 
szolgáltató.számlaLista.Add(new Számla(112885, szolgáltató.getÜgyfél(8), 3445, true)); 
szolgáltató.számlaLista.Add(new Számla(445222, szolgáltató.getÜgyfél(6), 3333, false)); 
szolgáltató.számlaLista.Add(new Számla(668901, szolgáltató.getÜgyfél(5), 2222, false)); 
szolgáltató.számlaLista.Add(new Számla(543888, szolgáltató.getÜgyfél(2), 6889, true)); 
szolgáltató.számlaLista.Add(new Számla(566743, szolgáltató.getÜgyfél(10), 7889, false)); 
szolgáltató.számlaLista.Add(new Számla(123667, szolgáltató.getÜgyfél(1), 3869, true)); 
szolgáltató.számlaLista.Add(new Számla(541234, szolgáltató.getÜgyfél(5), 4889, false)); 
szolgáltató.számlaLista.Add(new Számla(547555, szolgáltató.getÜgyfél(6), 2289, true)); 

szolgáltató.Input();




