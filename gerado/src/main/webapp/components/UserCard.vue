<template><v-container ></v-container><v-card-title ></v-card-title><v-row ></v-row><v-col ></v-col><v-avatar ></v-avatar><span id="new String(user.first_name).charAt(0).toUpperCase()">{{ new String(user.first_name).charAt(0).toUpperCase() }}</span><v-col ></v-col><span id="user.first_name">{{ user.first_name }}</span><v-card-text ></v-card-text><v-row ></v-row><v-col ></v-col><b id="user.roles[0].name">{{ user.roles[0].name }}</b><v-col ></v-col><b id="vuetify">{{ vuetify }}</b><v-col ></v-col><span id="user.email">{{ user.email }}</span><v-col ></v-col><span id="vuetify">{{ vuetify }}</span>
	</template>

<script>
export default {
    name: 'user-card',
	
	data: 
	{
		
	},	
	methods:
	{		
		
	}
}
</script>