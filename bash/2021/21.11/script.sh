#! /bin/bash

#опция -h (помощь)
if [[ "$1" = "-h" ]]; then
  echo "Программа поможет вам вывести статистику, скопировать файлы из одной директории в другую, создать архив с заданным именем"
  echo "Аргументы программы: опция(-s) входнаяДиректория выходнаяДиректория ИмяАрхива"
  exit 0
fi

#опция -s (без вывода в терминал)
s=false
if [[ "$1" = "-s" ]]; then
  s=true
  inputDir=$2
  outputDir=$3
  archive=$4
else
  inputDir=$1
  outputDir=$2
  archive=$3
fi

#проверка на кол-во аргументов
arguments=$#
if [ "$arguments" != "3" ] && [ "$s" = false ]; then
  echo "Указано неверное кол-во аргументов"
  exit 0
elif [ "$arguments" != "4" ] && [ "$s" = true ]; then
  echo "Указано неверное кол-во аргументов"
  exit 0
fi

files=0
for file in `find $inputDir -type f`
do
  files=$(($files+1))
done

dirs=$(find $inputDir . -maxdepth 1 -mindepth 1 -type d | wc -l)

if [ "$s" = true ] ; then
  echo "директории $dirs, файлы $files, $(du -hs $inputDir)" > /dev/null
else
  echo "директории $dirs, файлы $files, $(du -hs $inputDir)"
fi

for file in `find $inputDir -type f -name "*"`
do
  cp --backup=t $file $outputDir
done

if [ "$s" = true ] ; then
  tar -czf "$archive.tar.gz" $inputDir > /dev/null 2>&1
else
  tar -cvzf "$archive.tar.gz" $inputDir
fi