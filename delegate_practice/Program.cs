// Fenix Strickland 113437176
// Delegate
using delegate_folder;

FunctionTypeName funCard;
funCard = new FunctionTypeName(add);

funCard = add;

//funCard = mul; makes line 12 equal 200

funCard = (x, y) =>
 {
     return (x + y)*(x-y);
 };

double result = funCard(10, 20); //will output 30 because add function

double r = add(3, 4);


Console.ReadLine();

double mul(double db1, double db2)
{
    return db1 *db2;
}
double add(double db1, double db2)
{
    return db1 + db2;
}