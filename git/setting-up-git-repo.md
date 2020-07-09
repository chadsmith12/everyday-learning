# Setting up New Git Repo 

Today we learning about how to initialize a new Git Repo and tying it to a new GitHub remote.

## Initializing a Git Repo
To first initialize an empty Git Repo, first create and navigate to the directory that you want to setup a git repo in.  In this example it will be in `app`.

`mkdir app && cd app`

Once you have navigated to the directory you now will run `git init`. This command will initialize an empty git repo. If you `ls -a` to show all files in this empty git repo, you will see a directoy created called `.git`. 

You can setup the name and email to use for this git repo if you by chance do not want to use the global name and email already set in git. You can do with the following:

```
git config user.name "Your Name"
git config user.email "your.email@example.com"
```

If you would like to set this globally you can add a `--global` argument to this command

```
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

Now with the git repo initialized you are ready to tie this to your GitHub repo.

## Setting up GitHub
Now on your GitHub you will want to create a repository. Name the repository whatever you want and give it a small description.

When you create the GitHub repo leave it empty so you can initialie it. Once you hit create you will be taken to your empty repo, where it will give you instructions on how to add it as a remote to your git repo. The first set of instructions we can ignore, as we have already initialized a new repo. So  we will skip the second part which is how you add it as a remote to your git repo.

## Add remote to to your Git Repo
Now that the repo is created in GitHub we can tie that remote to your empty git repo on your local machine. To do this, we just need run one command. So on your local machine in the empty git repo that you just created, run the following:

`git remote add origin git@github.com:username/repoName.git`

Or, if you would like to use HTTPs instead replace the url with the https url. Example:

`git remote add origin https://github.com/username/repoName.git`

You will replace `username` with your GitHub username and `repoName` with the repo name of what you named it in GitHub.

## Completion
And that is it! You have created and initialied an empty git repo on your local machine, and set it up to have a remote to the GitHub repo that you created.