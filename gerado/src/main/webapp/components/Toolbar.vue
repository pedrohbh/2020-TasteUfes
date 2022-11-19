<template><v-app-bar ></v-app-bar><v-toolbar-title ></v-toolbar-title><router-link ></router-link><v-icon ></v-icon><span id="$vuetify">{{ $vuetify }}</span><v-spacer ></v-spacer><v-btn ></v-btn><v-btn ></v-btn>
	
	<menu-option />
	
	<menu-mobile />
	
	<login />
	</template>

<script>
export default {
    name: 'toolbar',
	
	components: {"MenuOption", "MenuMobile", "Login"},
	
	data: 
	{
		
	},	
	methods:
	{		
		
	}
}
</script>