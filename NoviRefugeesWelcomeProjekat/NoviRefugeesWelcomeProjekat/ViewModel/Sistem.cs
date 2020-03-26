﻿using NoviRefugeesWelcomeProjekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace NoviRefugeesWelcomeProjekat.ViewModel
{
    static public class Sistem
    {
        public static List<Izbjeglica> izbjeglice = new List<Izbjeglica>();
        public static List<Korisnik> korisnici = new List<Korisnik>();

        public async static void RegistrujIzbjeglicu(Izbjeglica iz)
        {
            for (int i = 0; i < izbjeglice.Count; i++)
            {
                if (izbjeglice[i].JMBG == iz.JMBG)
                {
                    //var dialog = new MessageDialog("Izbjeglica je vec registrovana!");
                    //await dialog.ShowAsync();
                }
            }
            izbjeglice.Add(iz);
            var dialog1 = new MessageDialog("Izbjeglica je uspješno registrovana!");
            await dialog1.ShowAsync();
            
         
        }
        public async static void ObrisiIzbjeglicu(string jmbg)
        {
            bool postoji = false;
            for (int i = 0; i < izbjeglice.Count; i++)
            {
                if (izbjeglice[i].JMBG == jmbg)
                {
                    var dialog = new MessageDialog("Izbjeglica je uspješno izbrisana!");
                    izbjeglice.Remove(izbjeglice.Find(x => x.JMBG == jmbg));
                    await dialog.ShowAsync();
                    postoji = true;
                }

            }
            if (postoji == false)
            {
                var dialog = new MessageDialog("Izbjeglica nije registrovana!");   
                await dialog.ShowAsync();
            }
           
        }

    }
}
