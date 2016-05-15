#!/bin/bash

echo "Making a new commit to the repo: Cab201-Yahtzee"

echo "Name this commit: "
read commit_name
echo "Starting"

echo "Adding changes..."
git add .

echo "Commiting changes.."
git commit -m "$commit_name"

echo "Pushing to master..."
git push origin master

echo "Making sure you've got the most up-to-date version..."
git pull

echo "Done!"
:
