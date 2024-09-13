file=($(find . ! -name "*.Designer.cs" -name "*.cs" -print0 | xargs -0 echo))
for i in "${file[@]}"
do
    :
    freeze $i -o "images/$(basename $i).png" --theme gruvbox --font.family "Jetbrains Mono" --font.size 12 --margin 20,60,20,40
done

