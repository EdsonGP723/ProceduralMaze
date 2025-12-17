using UnityEngine;

public class Crawler : Maze
{
    public override void Generate()
    {
        for (int i = 0; i < 3; i++)
            CrawlVertical();

        for (int i = 0; i < 2; i++)
            CrawlHorizontal();
    }

    void CrawlVertical()
    {
        bool done = false;
        //* Initial position of the crawler
        int x = Random.Range(1, width - 1);
        int z = 1;

        while (!done)
        {
            map[x, z] = 0; //* Mark the starting position as corridor
            if (Random.Range(0, 100) < 50) //* 50% chance to change direction
            {
                x += Random.Range(-1, 2); //* Move in x direction by -1, 0, or +1
            }
            else
            {
                z += Random.Range(0, 2); //* Move in z direction by -1, 0, or +1
            }
            done |= (x < 1 || x >= width - 1 || z < 1 || z >= depth - 1);
        }
    }
    void CrawlHorizontal()
    {
        bool done = false;
        //* Initial position of the crawler
        int x = 1;
        int z = Random.Range(1, depth - 1);

        while (!done)
        {
            map[x, z] = 0; //* Mark the starting position as corridor
            if (Random.Range(0, 100) < 50) //* 50% chance to change direction
            {
                x += Random.Range(0, 2); //* Move in x direction by -1, 0, or +1
            }
            else
            {
                z += Random.Range(-1, 2); //* Move in z direction by -1, 0, or +1
            }
            done |= (x < 1 || x >= width - 1 || z < 1 || z >= depth - 1);
        }
    }
}
