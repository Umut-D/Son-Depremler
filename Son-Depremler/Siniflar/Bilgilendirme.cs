﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Son_Depremler.Siniflar
{
    class Bilgilendirme
    {
        // Son depremi gösteren bilgi ekranını aktif et
        public void SonDeprem(ListView lvListe)
        {
            string zaman = Convert.ToDateTime(lvListe.Items[0].Text).ToShortTimeString();
            string yer = lvListe.Items[0].SubItems[5].Text;
            string buyukluk = lvListe.Items[0].SubItems[4].Text;

            if (true)
            {
                NotifyIcon bilgilendirmeMesaji = new NotifyIcon
                {
                    Visible = true,
                    Icon = SystemIcons.Information,
                    BalloonTipTitle = @"Son Deprem", BalloonTipText = @"Saat: " + zaman + Environment.NewLine + @"Yer: " + yer + Environment.NewLine + @"Büyüklük: " + buyukluk
                };

                bilgilendirmeMesaji.ShowBalloonTip(7000);
                bilgilendirmeMesaji.Dispose();
            }
        }

        public string SonGuncelleme()
        {
            DateTime tarih = DateTime.Now;

            return "Son Güncelleme: " + tarih.ToLongTimeString() + " (Sonraki otomatik güncelleme: " + tarih.AddMinutes(5).ToLongTimeString() + ")";
        }

        public void Hakkinda()
        {
            MessageBox.Show(@"Bu program ile; Boğaziçi Üniversitesi, Kandilli Rasathanesi ve Deprem Araştırma Enstitüsü (KRDAE) aracılığıyla sağlanan (son 20) deprem verilerini görebilirsiniz. Ayrıca, ilgili deprem(ler)e tıklayarak mevcut tarayıcınızda depremin olduğu lokasyonu görüntüleyebilirsiniz.", @"Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}