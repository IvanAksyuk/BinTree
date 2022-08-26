using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTrees
{
    internal class BinTree<T> where T : IComparable<T> 
    {
        private T? key;
        private BinTree<T>? left, right;

        public BinTree()
        {
            left = null;
            right = null;
            //key = null;
        }
        public BinTree(T? key, BinTree<T>? left=null, BinTree<T>? right=null)
        {
            this.key = key;
            this.left = left;
            this.right = right;
        }
        public void add(T key_)
        {
            if (this.key == null)
            {
                this.key = key_;
                return;
            }
            if (key_.CompareTo(this.key)>0)
            {
                if(this.right == null)
                {
                    this.right = new BinTree<T>(key_);
                } else
                {
                    this.right.add(key_);
                }
               
            } else
            {
                if (this.left == null)
                {
                    this.left = new BinTree<T>(key_);
                }
                else
                {
                    this.left.add(key_);
                }
            }
        }
        public T? get_key()
        {
            return this.key;
        }
        public bool find(T key_)
        {
            
           
            if (key_.CompareTo(this.key)==0)
            {
                
                return true;
            }
            if (key_.CompareTo(this.key) > 0)
            {
                if (this.right == null)
                {
                    return false;
                }
                else
                {
                    return this.right.find(key_);
                }

            }
            else
            {
                if (this.left == null)
                {
                    return false;
                }
                else
                {
                    return this.left.find(key_);
                }
            }
           
            
        }
        public  BinTree<T>? find_dot(T key_)
        {


            if (key_.CompareTo(this.key) == 0)
            {

                return  this;
            }
            if (key_.CompareTo(this.key) > 0)
            {
                if (this.right == null)
                {
                    return null;
                }
                else
                {
                    return this.right.find_dot(key_);
                }

            }
            else
            {
                if (this.left == null)
                {
                    return null;
                }
                else
                {
                    return this.left.find_dot(key_);
                }
            }


        }
      
        public void write_tree_1(BinTree<T>? root)
        {
            if (root == null)
            {
                return;
            }
            write_tree_1(root.left);
            Console.Write($"{root.key} ");
            write_tree_1(root.right);
        }
        public void write_tree_2(BinTree<T>? root)
        {
            if (root == null)
            {
                return;
            }
           
            Console.Write($"{root.key} ");
            write_tree_2(root.left);
            write_tree_2(root.right);
        }
        public void write_tree_3(BinTree<T>? root)
        {
            if (root == null)
            {
                return;
            }
            write_tree_3(root.left);
            write_tree_3(root.right);
            Console.Write($"{root.key} ");
            
        }
        public void write_tree_4(BinTree<T>? root)
        {
            if (root == null)
            {
                return;
            }
            write_tree_4(root.right);
            Console.Write($"{root.key} ");
            write_tree_4(root.left);
           
           

        }
    }
   
}
