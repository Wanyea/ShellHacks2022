using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratGrid : MonoBehaviour
{
    public GameObject Road;
    public GameObject SideRoad;
    public GameObject NotRoad;
    public GameObject Begining;
    public GameObject Ending;

    private int startX = 0;
    private int startZ = 0;
    private int prevX = 0;
    private int prevZ = 0;
    private int [,] grid = new int [100, 100];
    private int gridOffset = 50;
    private int Xmin = 0;
    private int Xmax = 0;
    private int Zmin = 0;
    private int Zmax = 0;

    //Individual Functions
    private void NS(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(z-Z == 0 || z-Z == 5){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(z-Z == 1 || z-Z == 4){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void EW(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(x-X == 0 || x-X == 5){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(x-X == 1 || x-X == 4){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void SE(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(z-Z == 0 || x-X == 0 || (z-Z == 5 && x-X == 5)){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(((z-Z == 1 || x-X == 1) && (z-Z != 0 && x-X != 0)) || (z-Z >= 4 && x-X >= 4)){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void SW(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(z-Z == 5 || x-X == 0 || (z-Z == 0 && x-X == 5)){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(((z-Z == 4 || x-X == 1) && (z-Z != 5 && x-X != 0)) || (z-Z <= 1 && x-X >= 4)){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void NE(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(z-Z == 0 || x-X == 5 || (z-Z == 5 && x-X == 0)){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(((z-Z == 1 || x-X == 4) && (z-Z != 0 && x-X != 5)) || (z-Z >= 4 && x-X <= 1)){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void NW(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                if(z-Z == 5 || x-X == 5 || (z-Z == 0 && x-X == 0)){
                    NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                    NotRoad.transform.SetParent(this.transform);
                }
                else if(((z-Z == 4 || x-X == 4) && (z-Z != 5 && x-X != 5)) || (z-Z <= 1 && x-X <= 1)){
                    SideRoad = Instantiate(SideRoad, pos, Quaternion.identity) as GameObject;
                    SideRoad.transform.SetParent(this.transform);
                }else{
                    Road = Instantiate(Road, pos, Quaternion.identity) as GameObject;
                    Road.transform.SetParent(this.transform);
                }
            }
        }
    }
    private void Begin(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                Begining = Instantiate(Begining, pos, Quaternion.identity) as GameObject;
                Begining.transform.SetParent(this.transform);

            }
        }
    }
    private void End(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                Ending = Instantiate(Ending, pos, Quaternion.identity) as GameObject;
                Ending.transform.SetParent(this.transform);

            }
        }
    }
    private void NRoad(int X, int Z){
        for(int z = Z; z < (Z + 6); z++){
            for(int x = X; x < (X + 6); x++){
                Vector3 pos = new Vector3(x, 0, z);
                NotRoad = Instantiate(NotRoad, pos, Quaternion.identity) as GameObject;
                NotRoad.transform.SetParent(this.transform);

            }
        }
    }

    //Moving X & Z
    void Xplus(){
        prevX = startX;
        prevZ = startZ;
        startX = startX + 6;
        GridMap();
    }
    void Zplus(){
        prevX = startX;
        prevZ = startZ;
        startZ = startZ + 6;
        GridMap();
    }
    void Xminus(){
        prevX = startX;
        prevZ = startZ;
        startX = startX - 6;
        GridMap();
    }
    void Zminus(){
        prevX = startX;
        prevZ = startZ;
        startZ = startZ - 6;
        GridMap();
    }

    //Random Generation !!!
    void RandomDirection(){
        switch (Random.Range(0, 4))
        {
            case 0:
                Xplus();
                RandomDownPath();
                break;
            case 1:
                Xminus();
                RandomUpPath();
                break;
            case 2:
                Zminus();
                RandomLeftPath();
                break;
            case 3:
                Zplus();
                RandomRightPath();
                break;
        }
    }

    //Random Paths
    void RandomUpPath(){
        switch (Random.Range(0, 3))
        {
            case 0:
                NS(startX, startZ);
                Xminus();
                NS(startX, startZ);
                Xminus();
                NS(startX, startZ);
                // Move pointer 
                Xminus();
                break;
            case 1:
                SE(startX, startZ);
                // Move pointer right
                Zplus();
                break;
            case 2:
                SW(startX, startZ);
                // Move pointer left
                Zminus();
                break;
        }
    }
    void RandomDownPath(){
        switch (Random.Range(0, 3))
        {
            case 0:
                NS(startX, startZ);
                Xplus();
                NS(startX, startZ);
                Xplus();
                NS(startX, startZ);
                // Move pointer down
                Xplus();
                break;
            case 1:
                NE(startX, startZ);
                // Move pointer right
                Zplus();
                break;
            case 2:
                NW(startX, startZ);
                // Move pointer left
                Zminus();
                break;
        }
    }
    void RandomRightPath(){
        switch (Random.Range(0, 3))
        {
            case 0:
                EW(startX, startZ);
                Zplus();
                EW(startX, startZ);
                Zplus();
                EW(startX, startZ);
                // Move pointer right
                Zplus();
                break;
            case 1:
                NW(startX, startZ);
                // Move pointer up
                Xminus();
                break;
            case 2:
                SW(startX, startZ);
                // Move pointer down
                Xplus();
                break;
        }
    }
    void RandomLeftPath(){
        switch (Random.Range(0, 3))
        {
            case 0:
                EW(startX, startZ);
                Zminus();
                EW(startX, startZ);
                Zminus();
                EW(startX, startZ);
                // Move pointer left
                Zminus();
                break;
            case 1:
                NE(startX, startZ);
                // Move pointer up
                Xminus();
                break;
            case 2:
                SE(startX, startZ);
                // Move pointer down
                Xplus();
                break;
        }
    }

    //Direction calculator
    string RoadDirection(){
        int X = startX - prevX;
        int Z = startZ - prevZ;
        if(X != 0){
            if(X > 0){
                // Down
                return "down";
            }else{
                // Up
                return "up";
            }
        }else{
            if(Z > 0){
                // Right
                return "right";
            }else{
                // Left
                return "left";
            }
        }
    }

    //Grid mapping
    void GridReset(){
        for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){
                grid[i,j] = 0;
            }
        }
    }
    void GridMap(){
        grid[startX/6 + gridOffset,startZ/6 + gridOffset] = 1;
    }
    //If empty return true
    bool GridCheck(){
        return grid[startX/6 + gridOffset,startZ/6 + gridOffset] == 0;
    }

    //Fill the grid
    void FillGrid(){
        for(int i = 0; i < 100; i++){
            for(int j = 0; j < 100; j++){
                if(grid[i,j] == 0){
                    NRoad((i - gridOffset) * 6, (j - gridOffset) * 6);
                    grid[i,j] = 2;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Start with everythign being a NotRoad
        GridReset();
        Begin(startX,startZ);
        GridMap();
        RandomDirection();
        for(int i = 0; i < 100; i++){
            if(RoadDirection() == "right"){
                //Path goes East
                RandomRightPath();
            }else if(RoadDirection() == "left"){
                //Path goes West
                RandomLeftPath();
            }else if(RoadDirection() == "down"){
                //Path goes South
                RandomDownPath();
            }else if(RoadDirection() == "up"){
                //Path goes North
                RandomUpPath();
            }
        }
        End(startX,startZ);
        //FillGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
