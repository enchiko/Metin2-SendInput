public class User{

     public static void main(String[] args){
        //DECLARE PLAYER
      Player p = new Player("Mirek",true,100);
      p.isAlive = false;
      
       
       
    }

   public class Player{

    public String name;
    public boolean isAlive;
    public int Health;

       public Player(String _name,boolean _isAlive, int _Health){
        this.name = _name;
        this.isAlive = _isAlive;
        this.Health = _Health;
       }
   }
}