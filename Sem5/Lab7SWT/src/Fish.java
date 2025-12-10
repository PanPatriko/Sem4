public class Fish {

    private String type;
    private String size;
    private String protectTime;

    public Fish(String type,String size,String protectTime)
    {
        this.type = type;
        this.size = size;
        this.protectTime = protectTime;
    }

    public String getProtectTime() {
        return protectTime;
    }

    public String getSize() {
        return size;
    }

    public String getType() {
        return type;
    }
}
