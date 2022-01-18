

public class TJava {
    public static void main(String[] args){
      Player p = new Player("Mirek",true,100);
      Show(p.name);      
    }

   public static class Player{

    public String name;
    public boolean isAlive;
    public int Health;

        public Player(String _name,boolean _isAlive, int _Health){
        this.name = _name;
        this.isAlive = _isAlive;
        this.Health = _Health;
       }
   }

    public static void Show(String o){
    System.out.println(o);
   }


}



