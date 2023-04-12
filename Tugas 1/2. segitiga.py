from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class Frmsegitiga:
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
        Label(mainFrame, text='Alas:').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi:').grid(row=0, column=5,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=3, column=0,
         sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=4, column=0,
         sticky=W, padx=5, pady=5)
        
# pasang textbox
        self.txtAlas = Entry(mainFrame)
        self.txtAlas.grid(row=0, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=1, column=1, padx=5, pady=5)
        self.txtSisi = Entry(mainFrame)
        self.txtSisi.grid(row=1, column=5, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=4, column=1, padx=5, pady=5)
    
    # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
           command=self.onHitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
    
# fungsi untuk menghitung luas dan keliling persegi Alas
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        Alas = int(self.txtAlas.get())
        Tinggi = int(self.txtTinggi.get())
        Sisi = int (self.txtSisi.get())
        luas = 0.5 * Alas * Tinggi
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        
        kel = Alas * Tinggi * Sisi
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk()
    aplikasi = Frmsegitiga(root, "Program Luas dan Keliling segitiga")
    root.mainloop()