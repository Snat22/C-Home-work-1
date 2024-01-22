int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for(int i = 0; i < n; i++){
        arr[i] = Convert.ToInt32(Console.ReadLine());
    
}
for(int i = 0; i < n; i++){
int cnt = 0;
for(int j = 0; j < n; i++){
    if(arr[i] == arr[j] && i != j){
        cnt++;
    }
    if(cnt > 0) System.Console.Write(arr[i]+ " ");
}

}
