class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{
//-------------------------------------
	//bu height bulma fonksiyonu
    //ciktisi asagida kullaniliacak
    //bizim fonk ic ice matruska gibi iterasyon ile inmeli
    //ilk basta hangisisni heighti buyukse onu almali-bunu alabilmek icin onun fonksiyonu da icerde caliscak en  alt dala kadar hepsi icice calisacak
    static int getHeight(Node root){
      
      if(root==null){
          return -1;//null ise de hata donsun
          
      }else{
          return (1 + Math.Max(getHeight(root.left), getHeight(root.right)));
          //burada giriyor icerisine bakiyor-onun icerisindekinin heightini olcmek icin onnunn icerisinin icerisine gidiyor ve hep max olani aliyor en son da arti 1
          
      }
      
    }
    
    /*asagida fiyorki
    nodo yok ise yarat
    node var ise 
            girdigindata roottan kucuk mi
                            kucuk ise bu girdigind atayi sol root a ata
                    degilse  sag tarafa ata
                    yan, saga dayal, buyumek istiyor
                    
    */
    //---------------------------------------------------

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}
