from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class Frmtrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
# pasang Label
        Label(mainFrame, text='Sisi_atas:').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi_bawah:").grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Tinggi:').grid(row=0, column=5,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=3, column=0,
         sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=4, column=0,
         sticky=W, padx=5, pady=5)
        
# pasang textbox
        self.txtSisi_atas = Entry(mainFrame)
        self.txtSisi_atas.grid(row=0, column=1, padx=5, pady=5)
        self.txtSisi_bawah = Entry(mainFrame)
        self.txtSisi_bawah.grid(row=1, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=1, column=5, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=4, column=1, padx=5, pady=5)
    
    # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
           command=self.onHitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
    
# fungsi untuk menghitung luas dan keliling persegi Sisi_atas
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        Sisi_atas = int(self.txtSisi_atas.get())
        Sisi_bawah = int(self.txtSisi_bawah.get())
        Tinggi = int (self.txtTinggi.get())
        Tambah = int (self.txtTambah.get())
        luas = (0.5 * (Sisi_atas * Sisi_bawah) * Tinggi,2)
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        
        kel = Sisi_atas + Sisi_bawah + Tinggi + tambah
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk()
    aplikasi = Frmtrapesium(root, "Program Luas dan Keliling trapesium")
    root.mainloop()