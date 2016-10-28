
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class ArrayOfKisi
{

    private ArrayOfKisiKisi[] kisiField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Kisi")]
    public ArrayOfKisiKisi[] Kisi
    {
        get
        {
            return this.kisiField;
        }
        set
        {
            this.kisiField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ArrayOfKisiKisi
{

    private string idField;

    private string adField;

    private string soyadField;

    private System.DateTime dogumTarihiField;

    private byte boyField;

    private byte kiloField;

    private ushort maasField;

    private bool kadinMiField;

    private string fotografField;

    /// <remarks/>
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Ad
    {
        get
        {
            return this.adField;
        }
        set
        {
            this.adField = value;
        }
    }

    /// <remarks/>
    public string Soyad
    {
        get
        {
            return this.soyadField;
        }
        set
        {
            this.soyadField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DogumTarihi
    {
        get
        {
            return this.dogumTarihiField;
        }
        set
        {
            this.dogumTarihiField = value;
        }
    }

    /// <remarks/>
    public byte Boy
    {
        get
        {
            return this.boyField;
        }
        set
        {
            this.boyField = value;
        }
    }

    /// <remarks/>
    public byte Kilo
    {
        get
        {
            return this.kiloField;
        }
        set
        {
            this.kiloField = value;
        }
    }

    /// <remarks/>
    public ushort Maas
    {
        get
        {
            return this.maasField;
        }
        set
        {
            this.maasField = value;
        }
    }

    /// <remarks/>
    public bool KadinMi
    {
        get
        {
            return this.kadinMiField;
        }
        set
        {
            this.kadinMiField = value;
        }
    }

    /// <remarks/>
    public string Fotograf
    {
        get
        {
            return this.fotografField;
        }
        set
        {
            this.fotografField = value;
        }
    }
}


