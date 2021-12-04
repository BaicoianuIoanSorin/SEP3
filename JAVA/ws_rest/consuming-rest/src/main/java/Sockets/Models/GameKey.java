package Sockets.Models;

import java.io.Serializable;

public class GameKey implements Serializable {
    private String GameKey;
    private String username;
    private static final long serialVersionUID = 6529685098267757691L;

    public GameKey(String GameKey, String username)
    {
        this.GameKey = GameKey;
        this.username = username;
    }

    public GameKey(String GameKey)
    {
        this.GameKey = GameKey;
        this.username = null;
    }

    public String getGameKey() {
        return GameKey;
    }

    public void setGameKey(String gameKey) {
        GameKey = gameKey;
    }
}
