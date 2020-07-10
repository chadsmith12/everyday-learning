## Setting up SSH Key on GitHub
We will learn how to generate new SSH Key and tie to this to your GitHub account. You will use this SSH Key to authenticate with GitHub when you are pushing items to a repository you have permission to push to.

These instructions will be written on a Mac. Though should be very similar on a Linux Distribution. Also using  Git Bash or WSL on Windows should work also.

### Generating the Key
* The first thing to do is open up your terminal.
* Run the following command, substituting your github email address in instead.

`ssh-keygen -t rsa -b 4096 -C "your_email@email.com"`

    - The `-t` option is selecting the algorithm to use. We will use RSA. 
    - The `-b` option is the number of bits. We will use 4096.
    - The '-C' option is saying we are using our email address as the key label.
* The key will be generated, and will ask you where to store the file. The default location is  `~/.ssh/id_rsa`
* Afterwards it will ask if you want to store this ssh key with a passphrase. Right now leave this empty. We will work with pass phrases later.

### Adding your SSH Key to your ssh-agent
Now that the key is generated we will want to store this key in our ssh-agent.

* Start the SSH Agent in the background with: `eval "$(ssh-agent -s)"`
* Run `ssh-add ~/.ssh/id_rsa`
* It is now time to add your key to GitHub.

### Add Your Key to GitHub
* The first thing you want to do is copy your key to your clipboard using: `pbcopy < ~/.ssh/id_rsa.pub`
    - This will copy your public key to your clipboard.
* Go to GitHub and go into your settings.
* Go to SSH and GPG Keys
* Click the New SSH Key button
* In the title field give your key a good descriptive title
* Paste your key into the key field.
* Click Add

### Completiton
You are now done! Your SSH Key has been added to GitHub and now you can start using the SSH Remote Url for your repo!


