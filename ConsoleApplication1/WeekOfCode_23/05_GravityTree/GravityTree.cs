using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    class Vert
    {
        public int Id { get; set; }
        public Vert Parent { get; set; }
        public List<Vert> Children { get; set; }
        public Vert()
        {
            Children = new List<Vert>();
        }
    }

    private static List<Vert> GetParents(Vert v)
    {
        Vert vRef = v;
        List<Vert> anc = new List<Vert>() { v };
        while (vRef.Parent != null)
        {
            anc.Add(vRef.Parent);
            vRef = vRef.Parent;
        }
        return anc;
    }

    private static Vert LCA(Vert v1, Vert v2)
    {
        List<Vert> parents1 = GetParents(v1);
        List<Vert> parents2 = GetParents(v2);

        List<Vert> intersect = parents1.Intersect(parents2).OrderBy(v => v.Id).ToList();
        return intersect.Last();
    }


    private static int Dist(Vert v1, Vert v2)
    {
        if (v1.Id == v2.Id)
            return 0;

        Vert lcaVert = LCA(v1, v2);

        int dist1 = 0;
        Vert v1Ref = v1;
        while (v1Ref.Id != lcaVert.Id)
        {
            dist1++;
            v1Ref = v1Ref.Parent;
        }

        int dist2 = 0;
        Vert v2Ref = v2;
        while (v2Ref.Id != lcaVert.Id)
        {
            dist2++;
            v2Ref = v2Ref.Parent;
        }

        return dist1 + dist2;
    }


    private static double MeaureForce(Vert current, Vert measurePoint)
    {
        int dist = Dist(current, measurePoint);
        double currentForce = dist * dist;

        foreach (Vert v in current.Children)
            currentForce += MeaureForce(v, measurePoint);

        return currentForce;
    }



    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("WeekOfCode_23\\05_GravityTree\\samples\\testCase1.txt"))
        {
            sr.ReadLine();
            int[] treeDef = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int q = int.Parse(sr.ReadLine());

            //initialize vertices tree
            Vert[] verts = new Vert[treeDef.Length + 1];
            for (int i = 0; i < verts.Length; i++)
            {
                verts[i] = new Vert() { Id = i + 1, Parent = null };
            }

            //fill parents references
            for (int i = 0; i < treeDef.Length; i++)
            {
                int parentId = treeDef[i];
                Vert parent = verts[parentId - 1];
                Vert current = verts[i + 1];
                current.Parent = parent;
                parent.Children.Add(current);
            }

            //run experiments
            for (int i = 0; i < q; i++)
            {
                int[] uv = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
                int u = uv[0];
                int v = uv[1];

                Vert turnedOn = verts.Where(vert => vert.Id == v).First();
                Vert measurePoint = verts.Where(vert => vert.Id == u).First();

                double f = MeaureForce(turnedOn, measurePoint);
                Console.WriteLine(f);
            }
        }

        Console.ReadLine();
    }
}